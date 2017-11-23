using System;
using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    public class LoginReply : OrcMessage
    {
        [DataMember(Name = "login_id")]
        public string UserName { get; set; }

        [DataMember(Name = "login_date")]
        public DateTime LoginDate { get; set; }

        [DataMember(Name = "login_time")]
        public TimeSpan LoginTime { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "utc_offset")]
        public int UtcOffset { get; set; }
    }
}