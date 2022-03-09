using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzzMVC.Models
{
    public class FizzBuzzViewModel
    {
        public FizzBuzzViewModel()
        {

        }
        public FizzBuzzViewModel(List<string> numbers, int fizzAmount, int buzzAmount, int woofAmount)
        {
            Numbers = numbers;
            FizzAmount = fizzAmount;
            BuzzAmount = buzzAmount;
            WoofAmount = woofAmount;
        }

        public List<string> Rules { get; set; }
        public List<string> Numbers { get; set; }
        public int FizzAmount { get; set; }
        public int BuzzAmount { get; set; } 
        public int WoofAmount { get; set; }
    }
}