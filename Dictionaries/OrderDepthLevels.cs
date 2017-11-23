using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "order_depth_levels", ItemName = "order_depth_level", Namespace = "")]
    public class OrderDepthLevels : List<OrderDepthLevel>
    {

    }

    public class OrderDepthLevel
    {
        [DataMember(Name = "ask")]
        public double? Ask { get; set; }

        [DataMember(Name = "ask_hidden_volume")]
        public bool? AskHiddenVolume { get; set; }

        [DataMember(Name = "ask_volume")]
        public double? AskVolume { get; set; }

        [DataMember(Name = "ask_ytm")]
        public double? AskYtm { get; set; }

        [DataMember(Name = "bid")]
        public double? Bid { get; set; }

        [DataMember(Name = "bid_hidden_volume")]
        public bool? BidHiddenVolume { get; set; }

        [DataMember(Name = "bid_volume")]
        public double? BidVolume { get; set; }

        [DataMember(Name = "bid_ytm")]
        public double? BidYtm { get; set; }

        [DataMember(Name = "ask_brokers")]
        public string AskBrokers { get; set; }

        [DataMember(Name = "bid_brokers")]
        public string BidBrokers { get; set; }

        [DataMember(Name = "bid_orders")]
        public int? BidOrders { get; set; }

        [DataMember(Name = "ask_orders")]
        public int? AskOrders { get; set; }
    }
}
