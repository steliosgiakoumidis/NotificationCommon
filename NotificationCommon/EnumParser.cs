using NotificationCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationCommon
{
    public static class EnumParser
    {
        public static Enums.RepetitionFrequency RepetitionFrequencyStringToEnum(this string repoetitionFrequency)
        {
            return Enum.TryParse(repoetitionFrequency, true, out Enums.RepetitionFrequency repFreq) ?
                repFreq :
                throw new InvalidCastException("Repetition frequency string does not correspond to any enum");
        }
        public static Enums.ExecutionTime ExecutionTimeStingToEnum(this int executionTime)
        {
            return Enum.TryParse(executionTime.ToString(), true, out Enums.ExecutionTime execTime) ?
                execTime :
                throw new InvalidCastException("RExecution time string does not correspond to any enum");
        }
        public static Enums.DayOfTheWeek DayOfTheWeekStingToEnum(this string dayOfTheWeek)
        {
            return Enum.TryParse(dayOfTheWeek, true, out Enums.DayOfTheWeek dayOfWeek) ?
                dayOfWeek :
                throw new InvalidCastException("Day of the week string does not correspond to any enum");
        }

        public static Enums.MeansOfCommunication MeansOfCommunicationStingToEnum(this string meansOfCommunication)
        {
            return Enum.TryParse(meansOfCommunication, true, out Enums.MeansOfCommunication meansOfComm) ?
                meansOfComm :
                throw new InvalidCastException("Means of communication string does not correspond to any enum");
        }
    }
}
