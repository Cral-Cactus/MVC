using System;

namespace MagicNumbers.Views
{
    public class Display
    {
        public int MagicNumber { get; set; }
        public string Output { get; set; }
        private bool useConsole;

        public Display(bool useConsole = true)
        {
            this.useConsole = useConsole;
        }

        public void InputNumber()
        {
            if (this.useConsole)
            {
                Console.WriteLine("Please enter a number:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int magicNumber))
                {
                    MagicNumber = magicNumber;
                }
                else
                {
                    throw new ArgumentException("Invalid input. Please enter a number.");
                }
            }
        }

        public void DisplayMagicNumber(string number)
        {
            if (this.useConsole)
            {
                Console.Write($"{number} ");
            }
        }
    }
}