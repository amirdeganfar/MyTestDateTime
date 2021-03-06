﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestDateTime
{
    public static class DateTimeUtility
    {
        public static int days(DateTimeOffset start, DateTimeOffset end, TimeFrame? timeFrame = null)
        {
            int days = (int)(end - start).TotalDays;

            switch (timeFrame)
            {
                case TimeFrame.Second:
                    return (days * 24 * 60 * 60);
                case TimeFrame.Minute:
                    return (days * 24 * 60);
                case TimeFrame.Hour:
                    return (days * 24);
                case TimeFrame.Year:
                    return (days / 365);
                default:
                    break;
            }
            return (int)days;
        }

        public static int WeekDays(DateTimeOffset start, DateTimeOffset end)
        {
            int days = 0;
            do
            {
                if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
                {
                    ++days;
                }
                start = start.AddDays(1);
            } while (start < end);
            return days;
        }

        public static int Weeks(DateTimeOffset start, DateTimeOffset end)
        {
            int completeWeek = 0;
            bool IsMondayMeeted = false;

            while (start < end)
            {
                if ((start.DayOfWeek == DayOfWeek.Monday) || IsMondayMeeted)
                {
                    IsMondayMeeted = true;
                    if (start.DayOfWeek == DayOfWeek.Saturday)
                    {
                        ++completeWeek;
                        IsMondayMeeted = false;
                    }
                }
                start = start.AddDays(1);
            }
            return completeWeek;
        }
    }
}
