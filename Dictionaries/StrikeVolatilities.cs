using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "strike_volatilities", ItemName = "strike_volatility", Namespace = "")]
    public class StrikeVolatilities : List<StrikeVolatility>
    {
    }

    [DataContract(Name = "strike_volatility", Namespace = "")]
    public class StrikeVolatility
    {
        /// <summary>
        /// The strike price.
        /// </summary>
        [DataMember(Name = "strikeprice", IsRequired = true, Order = 1)]
        public double? StrikePrice { get; set; }

        /// <summary>
        /// The volatility for the above strike price. 
        /// Note that the volatility is not expressed in percent, i.e.to specify 27% for a strike 0.27 should be entered.
        /// </summary>
        [DataMember(Name = "volatility", IsRequired = true, Order = 2)]
        public double? Volatility { get; set; }
    }
}