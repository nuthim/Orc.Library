using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "calculation_results", ItemName = "calculation_result", Namespace = "")]
    public class CalculationResults : List<CalculationResult>
    {

    }

    [DataContract(Name = "calculation_result", Namespace = "")]
    public class CalculationResult
    {
        [DataMember(Name = "action")]
        public string Action { get; set; }

        [DataMember(Name = "result")]
        public double? Result { get; set; }

        [DataMember(Name = "error")]
        public int? Error { get; set; }
    }
}