using System;
using System.Web.Mvc;
using Blair_WhenCanIClockOut_2._0.Interfaces;
using Blair_WhenCanIClockOut_2._0.Models;

namespace Blair_WhenCanIClockOut_2._0.Controllers
{
	public class HomeController : Controller
	{
		private ICalculationService calculationService;

		public HomeController(ICalculationService calculationService)
		{
			this.calculationService = calculationService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Submit(DateTimeModel formData)
		{
			DateTime timeOut = calculationService.CalculateTimeOut(formData.LastPunch, formData.CurrentHours, formData.DesiredHours);
			DateTimeModel dateTimeModel = calculationService.PopulateModel(timeOut);
			return PartialView("~/Views/Shared/_outTimeMessage.cshtml", dateTimeModel);
		}
	}
}

////https://www.c-sharpcorner.com/article/different-types-of-action-results-in-asp-net-mvc/