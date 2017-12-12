using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    [DataContract(Name = "NEWS_ARTICLE_GET", Namespace = "")]
    public class NewsArticleGetReply : ServerMessage
    {
        [DataMember(Name = "identifier", Order = 1)]
        public string Identifier { get; set; }

        [DataMember(Name = "article_text", Order = 2)]
        public string ArticleText { get; set; }
    }

    [DataContract(Name = "NEWS_BROADCAST", Namespace = "")]
    public class NewsBroadcastReply : ServerMessage
    {

    }
}
