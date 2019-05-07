using static NotificationCommon.Models.Enums;

namespace NotificationCommon.Models
{
    public class GatewaySendout
    {
        public string Text { get; set; }
        public string ContactDetails { get; set; }

        public MeansOfCommunication MeansOfCommunication { get; set; }
    }
}
