using System;
using System.ComponentModel.DataAnnotations;

namespace NotificationCommon.Models
{
    public class Sendout
    {
        public int Id { get; set; }
        public string ReminderName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        public Enums.RepetitionFrequency RepetitionFrequency { get; set; }
        public Enums.ExecutionTime ExecutionTime { get; set; }
        public Enums.DayOfTheWeek DayOfTheWeek { get; set; }
        public DateTime? LastRunAt { get; set; }
        public string Parameters { get; set; }
        public string Username { get; set; }
        public string UserGroup { get; set; }
        public string TemplateName { get; set; }

        public Sendout() { }

        public Sendout(int id, string reminderName, DateTime startDate, 
            Enums.RepetitionFrequency repetitionFrequency, Enums.ExecutionTime executionTime, 
            Enums.DayOfTheWeek dayOfTheWeek, DateTime? lastRunAt, string parameters,
            string username, string userGroup, string templateName)
        {
            Id = id;
            ReminderName = reminderName;
            StartDate = startDate;
            RepetitionFrequency = repetitionFrequency;
            ExecutionTime = executionTime;
            DayOfTheWeek = dayOfTheWeek;
            LastRunAt = lastRunAt;
            Parameters = parameters;
            Username = username;
            UserGroup = userGroup;
            TemplateName = templateName;
        }
    }
}
