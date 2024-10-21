using System;

namespace MagicNumbers.Views
{
    public class Display
    {
        public int MagicNumber { get; set; }
        public string Output { get; set; } = string.Empty;
        public bool IsConsole { get; set; } = true;

        public void InputNumber()
        {
            if (IsConsole)
            {
                Console.WriteLine("Please enter a number:");
                MagicNumber = int.Parse(Console.ReadLine());
            }
        }

        public virtual void DisplayMagicNumber()
        {
            if (IsConsole)
            {
                Console.WriteLine(Output);
            }
        }
    }
}