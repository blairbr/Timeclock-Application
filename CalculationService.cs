using Blair_WhenCanIClockOut_2._0.Interfaces;
using System;
using Blair_WhenCanIClockOut_2._0.Models;


namespace Blair_WhenCanIClockOut_2._0.Services
{
	public class CalculationService : ICalculationService
	{
		public DateTime CalculateTimeOut(string lastPunch, string currentHours, string desiredHours)
		{
			DateTime lastPunchAsDateTime = DateTime.Parse(lastPunch);
			float hoursRemaining = float.Parse(desiredHours) - float.Parse(currentHours);
			TimeSpan timeRemaining = TimeSpan.FromHours(hoursRemaining);
			var clockOutTime = lastPunchAsDateTime.Add(timeRemaining);
			
			return clockOutTime;
		}

		public DateTimeModel PopulateModel(DateTime clockOutTime)
		{
			DateTimeModel dateTimeModel = new DateTimeModel()
			{
				ClockoutTime = clockOutTime
			};
			return dateTimeModel;
		}
	}
}