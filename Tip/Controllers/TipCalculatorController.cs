using System;
using TipApp.Views;
using TipApp.Models;

namespace TipApp.Controllers
{
    public class TipController
    {
        Display display;
        Tip newTip;

        public TipController()
        {
            display = new Display();

            display.ReadingData();

            newTip = new Tip(display.Bill, display.Tip);

            display.Total = newTip.CalculateTotal();

            display.WritingData();
        }
    }
}