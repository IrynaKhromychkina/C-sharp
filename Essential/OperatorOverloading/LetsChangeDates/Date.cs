using System;

namespace LetsChangeDates
{
    class Date
    {
        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public Date(DateTime date)
        {
            dateTime = date;
        }

        public static double operator -(Date firstDate, Date secondDate)
        {
            TimeSpan daysLeft = firstDate.dateTime - secondDate.dateTime;
            double daysLeftDouble = daysLeft.TotalDays;
            return daysLeftDouble;
        }

        public static Date operator +(Date date, int days)
        {
            DateTime thisDateTime = date.dateTime;
            DateTime secondDateTime = thisDateTime.AddDays(days);
            Date nextDate = new Date(secondDateTime);
            return nextDate;
        }
    }
}
