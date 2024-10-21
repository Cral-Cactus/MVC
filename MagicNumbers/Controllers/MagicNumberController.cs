using MagicNumbers.Models;
using MagicNumbers.Views;
using System;

namespace MagicNumbers.Controllers
{
    public class MagicNumberController
    {
        private MagicNumber magicNumber;
        private Display display;
        private DisplayWinForms displayWinForms;

        public MagicNumberController(bool useConsole)
        {
            display = new Display { IsConsole = useConsole };
            if (useConsole)
            {
                display.InputNumber();
                ProcessMagicNumber(display.MagicNumber);
            }
        }

        public void ProcessMagicNumber(int magicNumberInput)
        {
            magicNumber = new MagicNumber(magicNumberInput);
            magicNumber.FindMagicNumbers();
            display.Output = magicNumber.Output;

            if (display.IsConsole)
            {
                display.DisplayMagicNumber();
            }
        }

        public void SetOutputForWinForms(MagicNumberForm form)
        {
            form.DisplayMagicNumber(magicNumber.Output);
        }
    }
}
