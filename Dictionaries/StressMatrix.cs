using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "stress_matrix", ItemName = "stress_matrix_entry", Namespace = "")]
    public class StressMatrix : List<StressMatrixEntry>
    {

    }

    [DataContract(Name = "stress_matrix_entry", Namespace = "")]
    public class StressMatrixEntry
    {
        [DataMember(Name = "result_currency", Order = 1)]
        public string ResultCurrency { get; set; }

        [DataMember(Name = "simulation_results", Order = 2)]
        public SimulationResults SimulationResults { get; set; }

        [DataMember(Name = "underlying", Order = 3)]
        public string Underlying { get; set; }

        [DataMember(Name = "expirydate", Order = 4)]
        public DateTime? ExpiryDate { get; set; }

        [DataMember(Name = "instrument_id", Order = 5)]
        public InstrumentId InstrumentId { get; set; }
    }
}