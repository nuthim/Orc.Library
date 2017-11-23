using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "spread_table", Namespace = "")]
    public enum SpreadTable
    {

        /// <summary>
        /// [none] always exist. The others tables can be found by sending the spreadtable_download message.
        /// </summary>
        [EnumMember(Value = "[none]")]
        None
    }
}
