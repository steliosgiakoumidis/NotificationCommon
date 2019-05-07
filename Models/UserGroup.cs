using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationCommon.Models
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string UserIds { get; set; }
        public UserGroup() { }

        public UserGroup(int id, string groupName, string userIds)
        {
            Id = id;
            GroupName = groupName;
            UserIds = userIds;
        }
    }
}
