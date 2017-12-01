using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// This message allows you to get news from, for example, SFC.
    /// </summary>
    [DataContract(Name = "NEWS_ARTICLE_GET", Namespace = "")]
    public class NewsArticleGetMessage : ClientMessage
    {
        [DataMember(Name = "identifier", IsRequired = true)]
        public string Identifier { get; set; }

        public NewsArticleGetMessage() : base( MessageType.NEWS_ARTICLE_GET)
        {

        }
    }

    /// <summary>
    /// Send information to the text ticker in Orc Trader. 
    /// </summary>
    [DataContract(Name = "NEWS_BROADCAST", Namespace = "")]
    public class NewsBroadcastMessage : ClientMessage
    {
        /// <summary>
        /// Text that will appear in the text ticker in the Orc Trader
        /// </summary>
        [DataMember(Name = "text", IsRequired = true)]
        public string Text { get; set; }

        public NewsBroadcastMessage() : base(MessageType.NEWS_BROADCAST)
        {

        }
    }
}
