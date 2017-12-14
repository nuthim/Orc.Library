using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "simulation_results", ItemName = "simulation_result", Namespace = "")]
    public class SimulationResults : List<SimulationResult>
    {

    }

    [DataContract(Name = "stress_matrix_entry", Namespace = "")]
    public class SimulationResult
    {
        [DataMember(Name = "simulated_price", Order = 1)]
        public double? SimulatedPrice { get; set; }

        [DataMember(Name = "simulated_volatility", Order = 2)]
        public double? SimulatedVolatility { get; set; }

        [DataMember(Name = "calculation_results", Order = 3)]
        public CalculationResults CalculationResults { get; set; }
    }
}