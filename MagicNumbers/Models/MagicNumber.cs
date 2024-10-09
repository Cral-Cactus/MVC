using System;

namespace MagicNumbers.Models
{
    public class MagicNumber
    {
        private int number;

        public int Number
        {
            get { return this.number; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be greater than 0");
                }
                this.number = value;
            }
        }

        public MagicNumber(int number)
        {
            this.Number = number;
        }

        public bool IsMagicNumber(int i, int b, int c, int d, int e, int f)
        {
            return i * b * c * d * e * f == this.Number;
        }

        public void FindMagicNumbers(Action<string> displayMagicNumber)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            for (int e = 1; e <= 9; e++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {
                                    if (IsMagicNumber(i, b, c, d, e, f))
                                    {
                                        displayMagicNumber($"{i}{b}{c}{d}{e}{f}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}