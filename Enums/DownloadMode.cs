using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "download_mode", Namespace = "")]
    public enum DownloadMode
    {
        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "full")]
        Full,

        [EnumMember(Value = "full with dynamic parameters")]
        FullWithDynamicParameters
    }
}