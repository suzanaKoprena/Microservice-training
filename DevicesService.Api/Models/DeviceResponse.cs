using DevicesService.Api.Enums;

namespace DevicesService.Api.Models
{
    public class DeviceResponse
    {
        public string? MAC { get; set; }
        public string? HostName { get; set; }
        public string? IpAddress { get; set; }
        public DeviceType? DeviceType { get; set; }
        public string? Vendor { get; set; }
        public string? Model { get; set; }
    }
}
