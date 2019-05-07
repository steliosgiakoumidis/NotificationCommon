using static NotificationCommon.Models.Enums;

namespace NotificationCommon.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string NotificationText { get; set; }
        public string NotificationName { get; set; }
        public MeansOfCommunication NotificationPriority { get; set; }

        public Template() {}
        public Template(int id, string notificationText, string notificationName, MeansOfCommunication notificationPriority)
        {
            Id = id;
            NotificationText = notificationText;
            NotificationName = notificationName;
            NotificationPriority = notificationPriority;
        }
    }
}
