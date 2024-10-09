using MagicNumbers.Models;
using MagicNumbers.Views;
using System;

namespace MagicNumbers.Controllers
{
    public class MagicNumberController
    {
        MagicNumber magicNumber;
        Display display;
        private readonly Action<string> displayAction;

        public MagicNumberController(bool useConsole = true)
        {
            display = new Display(useConsole);

            if (useConsole)
            {
                display.InputNumber();
                magicNumber = new MagicNumber(display.MagicNumber);
                magicNumber.FindMagicNumbers(display.DisplayMagicNumber);
            }
        }

        public MagicNumberController(int magicNumber, Action<string> displayAction)
        {
            this.magicNumber = new MagicNumber(magicNumber);
            this.displayAction = displayAction;
            this.magicNumber.FindMagicNumbers(displayAction);
        }
    }
}
