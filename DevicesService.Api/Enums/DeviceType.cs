using System.Runtime.Serialization;

namespace DevicesService.Api.Enums
{
    public enum DeviceType
    {
        [EnumMember(Value = @"router")]
        Router,
        [EnumMember(Value = @"switch")]
        Switch,
        [EnumMember(Value = @"modem")]
        Modem
    }
}
