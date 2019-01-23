using System;
using Blair_WhenCanIClockOut_2._0.Models;

namespace Blair_WhenCanIClockOut_2._0.Interfaces
{
	public interface ICalculationService
	{
		DateTime CalculateTimeOut(string lastPunch, string currentHours, string desiredHours);

		DateTimeModel PopulateModel(DateTime clockOutTime);

	}
}
