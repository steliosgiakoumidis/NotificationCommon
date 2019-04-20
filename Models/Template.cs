using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationCommon.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string NotificationText { get; set; }
        public string NotificationName { get; set; }
        public string NotificationPriority { get; set; }
    }
}
