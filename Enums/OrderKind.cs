using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "order_kind", Namespace = "")]
    public enum OrderKind
    {
        [EnumMember(Value = "Normal order")]
        NormalOrder,

        /// <summary>
        /// Not allowed for contracts of type "Mini-basket".
        /// </summary>
        [EnumMember(Value = "Parent order")]
        ParentOrder
    }
}