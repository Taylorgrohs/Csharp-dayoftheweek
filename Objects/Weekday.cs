using System;
using System.Collections.Generic;

namespace WeekdayFinder
{
  public class Weekday
  {
    public string FindWeekday(int day, int month, int year)
    {
      int inputDay = day;
      int inputMonth = month - 1;
      int inputYear = year;
      int totalDays = 0;

      int startDay = 1;
      int startMonth = 1;
      int startYear = 1970;

      int numberOfLeapDays = 0;

      int daysInYear = 365;

      int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

      int daysInWeek = 7;

      int totalYears = inputYear - startYear;
      int totalYearDays = totalYears * daysInYear;
      int totalMonthDays = 0;
      for (int i = 0; i < inputMonth; i++)
      {
        totalMonthDays += daysInMonths[i];
      }
      int totalWeekDays = (inputDay - startDay);

      numberOfLeapDays = ((totalYears -2) / 4) + 1;

      totalDays = totalYearDays + totalMonthDays + totalWeekDays + numberOfLeapDays;

      int dayOfWeek = totalDays % daysInWeek;
      string outputDay;
      if (dayOfWeek == 0)
      {
        outputDay = "Thursday";
      }
      else if (dayOfWeek == 1)
      {
        outputDay = "Friday";
      }
      else if (dayOfWeek == 2)
      {
        outputDay = "Saturday";
      }
      else if (dayOfWeek == 3)
      {
        outputDay = "Sunday";
      }
      else if (dayOfWeek == 4)
      {
        outputDay = "Monday";
      }
    }
  }
}
