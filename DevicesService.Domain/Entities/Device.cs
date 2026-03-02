
using DevicesService.Api.Enums;

namespace DevicesService.Domain.Entities
{
    public class Device
    {
        public required Guid Id { get; set; }
        public string? MAC { get; set; }
        public required string HostName { get; set; }
        public string? IpAddress { get; set; }
        public DeviceType? DeviceType { get; set; }
        public string? Vendor { get; set; }
        public string? Model { get; set; }
    }
}
