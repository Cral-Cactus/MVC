using MagicNumbers.Models;
using MagicNumbers.Views;

namespace MagicNumbers.Controllers
{
    public class MagicNumberController
    {
        MagicNumber magicNumber;
        Display display;

        public MagicNumberController()
        {
            display = new Display();

            display.InputNumber();

            magicNumber = new MagicNumber(display.MagicNumber);

            magicNumber.FindMagicNumbers(display.DisplayMagicNumber);
        }
    }
}