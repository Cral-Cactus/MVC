using System;

namespace MagicNumbers.Views
{
    public class Display
    {
        public int MagicNumber { get; set; }
        public string Output { get; set; }
        public void InputNumber()
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

        public void DisplayMagicNumber(string number)
        {
            Console.Write($"{number} ");
        }
    }
}