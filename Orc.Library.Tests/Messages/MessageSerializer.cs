using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using Orc.Library.Messages;


namespace Orc.Library.Tests.Messages
{
    internal abstract class MessageSerializer
    {
        private const string _root = @"..\..\Messages";

        public void SerializeAll(bool overwrite = false)
        {
            foreach (var messageType in GetTypes())
            {
                Serialize(messageType, overwrite);
            }
        }

        //public void DeserializeAll()
        //{
        //    var assembly = typeof(ClientMessage).Assembly;

        //    foreach (var fileName in Directory.GetFiles(Path.Combine(_path, GetFolderName()), "*.xml"))
        //    {
        //        var type = Type.GetType(Path.GetFileNameWithoutExtension(fileName));
        //        if (type == null)
        //            continue;

        //        var serializer = new DataContractSerializer(type);
        //        var textReader = new StringReader(File.ReadAllText(fileName));
        //        using (var reader = XmlReader.Create(textReader))
        //        {
        //            deserializedObject = serializer.ReadObject(reader);
        //        }
        //        Serialize(messageType, Path.Combine(_path, GetFolderName()), overwrite);
        //    }
        //}

        public void Serialize(Type type, bool overwrite)
        {
            var message = Activator.CreateInstance(type);

            var serializer = new DataContractSerializer(type);

            var builder = new StringBuilder();
            var writerSettings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true, OmitXmlDeclaration = true };
            using (var writer = XmlWriter.Create(builder, writerSettings))
            {
                serializer.WriteObject(writer, message);
                writer.Close();
            }

            var fileName = GetFileName(type);

            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, builder.ToString());
        }

        public static string Serialize<T>(T instance)
        {
            var serializer = new DataContractSerializer(typeof(T));
            var builder = new StringBuilder();
            var writerSettings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true, OmitXmlDeclaration = true };
            using (var writer = XmlWriter.Create(builder, writerSettings))
            {
                serializer.WriteObject(writer, instance);
                writer.Close();
            }

            return builder.ToString();
        }

        public static T Deserialize<T>(string content)
        {
            var serializer = new DataContractSerializer(typeof(T));
            var textReader = new StringReader(content);
            using (var reader = XmlReader.Create(textReader))
            {
                return (T)serializer.ReadObject(reader);
            }
        }

        protected abstract string GetFolderName();

        protected abstract IEnumerable<Type> GetTypes();

        protected string GetFileName(Type type)
        {
            return Path.Combine(Path.Combine(_root, GetFolderName()), $"{type.Name}.xml");
        }
    }

    internal class ClientMessageSerializer : MessageSerializer
    {
        protected override string GetFolderName()
        {
            return "Client";
        }

        protected override IEnumerable<Type> GetTypes()
        {
            var assembly = typeof(ClientMessage).Assembly;
            return assembly.ExportedTypes.Where(x => !x.IsAbstract && x.IsSubclassOf(typeof(ClientMessage))).OrderBy(x => x.Name);
        }

        public T Deserialize<T>()
        {
            var serializer = new DataContractSerializer(typeof(T));
            var fileName = GetFileName(typeof(T));

            var textReader = new StringReader(File.ReadAllText(fileName));
            using (var reader = XmlReader.Create(textReader))
            {
                return (T)serializer.ReadObject(reader);
            }
        }
    }

    internal class ServerMessageSerializer : MessageSerializer
    {
        protected override string GetFolderName()
        {
            return "Server";
        }

        protected override IEnumerable<Type> GetTypes()
        {
            var assembly = typeof(ServerMessage).Assembly;
            return assembly.ExportedTypes.Where(x => !x.IsAbstract && x.IsSubclassOf(typeof(ServerMessage))).OrderBy(x => x.Name);
        }
    }
}
