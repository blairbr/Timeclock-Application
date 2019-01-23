using System;
using System.ComponentModel.DataAnnotations;

namespace Blair_WhenCanIClockOut_2._0.Models
{
	public class DateTimeModel
	{
		public DateTime ClockoutTime { get; set; }


		[Display(Name ="Desired Hours")]
		public string DesiredHours { get; set; }

		[Display(Name ="Current Hours")]
		public string CurrentHours { get; set; }

		[Display(Name ="Last Punch")]
		public string LastPunch { get; set; }
	}
}