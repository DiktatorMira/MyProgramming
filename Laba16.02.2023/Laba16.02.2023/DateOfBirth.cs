using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba16._02._2023 {
    struct DateOfBirth {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public DateOfBirth(int year, int month, int day) {
            Year = year;
            Month = month;
            Day = day;
        }
        internal string CheckDayOfWeek() {
            string[] temp = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            DateTime dt = new DateTime(Year, Month, Day);
            return temp[(int)dt.DayOfWeek - 1]; 
        }
        internal int DaysToBirthday() {
            DateTime now = DateTime.Now;
            DateTime next_date = new DateTime(now.Year, Month, Day);
            if(now.Month > Month) next_date.AddYears(1);
            else if(Month == now.Month && now.Day > Day) next_date.AddYears(1);
            return (int)(next_date - now).TotalDays;
        }
        internal void SetDate(int year, int month, int day) {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
