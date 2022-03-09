using FizzBuzzMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FizzBuzzViewModel fbModel = new FizzBuzzViewModel()
            {
                Numbers = GetResults(),
                FizzAmount = CalculateFizzAmount(),
                BuzzAmount = CalculateBuzzAmount(),
                WoofAmount = CalculateWoofAmount()
            };
            
            return View(fbModel);
        }

        private string OutputString(int value)
        {
            var returnStr = string.Format($"{CheckForFizz(value)}{CheckForBuzz(value)}{CheckForWoof(value)}");
            return !string.IsNullOrEmpty(returnStr) ? returnStr : value.ToString();
        }

        private string CheckForFizz(int value) => value % 3 == 0 ? "Fizz" : string.Empty;

        private string CheckForBuzz(int value) => value % 5 == 0 ? "Buzz" : string.Empty;

        private string CheckForWoof(int value) => value % 7 == 0 ? "Woof" : string.Empty;

        private List<string> GetResults()
        {
            var fbNumbers = new List<string>();
            Enumerable.Range(1, 100).ToList().ForEach(i => fbNumbers.Add(OutputString(i)));
            return fbNumbers;
        }

        private int CalculateFizzAmount() => (100 / 3);
        private int CalculateBuzzAmount() => (100 / 5);
        private int CalculateWoofAmount() => (100 / 7);
    }
}