using DevicesService.Api.Enums;
using System.ComponentModel.DataAnnotations;

namespace DevicesService.Api.Models
{
    public class DeviceRequest
    {
        [RegularExpression(@"^([0-9A-Fa-f]{2}([-:])){5}[0-9A-Fa-f]{2}$", ErrorMessage = "Invalid MAC address format")]
        public string? MAC {  get; set; }
        public string? HostName { get; set; }

        [RegularExpression(@"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$", ErrorMessage = "Invalid ip address format")]
        public string? IpAddress { get; set; }
        public DeviceType? DeviceType { get; set; }
        public string? Vendor { get; set; }
        public string? Model { get; set; }
    }
}
