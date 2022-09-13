namespace WeekdayCalculationRestAPI.Common
{
    public static class CommonMethod
    {
        private static readonly DayOfWeek[] weekDays = new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };

        public static List<string> GetWeekdayListFromDate(DateTime dt)
        {
            var returnList = new List<string>();
            for (DateTime date = dt; returnList.Count < 7; date = date.AddDays(1))
            {
                if (weekDays.Contains(date.DayOfWeek))
                    returnList.Add(returnList.Count + "." + date.DayOfWeek.ToString() + " - " + date.ToString());
            }
            return returnList;
        }
    }
}
