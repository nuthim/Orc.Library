using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "order_validate", Namespace = "")]
    public enum OrderValidate
    {
        [EnumMember(Value = "Allow orders")]
        AllowOrders,

        [EnumMember(Value = "Validate orders")]
        ValidateOrders,

        [EnumMember(Value = "Validate orders using rules")]
        ValidateOrdersUsingRules,

        [EnumMember(Value = "Stop orders")]
        StopOrders
    }

}