using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Server
{
    [DataContract(Name = nameof(MessageType.LOGOUT), Namespace = "")]
    public class LoginReply : ServerMessage
    {
        [DataMember(Name = "login_id")]
        public string LoginId { get; set; }

        [DataMember(Name = "login_date")]
        public DateTime? LoginDate { get; set; }

        [DataMember(Name = "login_time")]
        public TimeSpan? LoginTime { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "utc_offset")]
        public int? UtcOffset { get; set; }

        [DataMember(Name = "configuration_file")]
        public ConfigurationFile ConfigurationFile { get; set; }

    }
}