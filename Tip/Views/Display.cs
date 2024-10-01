﻿using System;

namespace TipApp.Views
{
    public class Display
    {
        public double Bill { get; set; }
        public double Tip { get; set; }
        public double Total { get; set; }

        public void ReadingData()
        {
            Console.WriteLine("bill amount:");
            Bill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tip percentage:");
            Tip = Convert.ToDouble(Console.ReadLine());
        }

        public void WritingData()
        {
            Console.WriteLine($"bill amount: {Bill}");
            Console.WriteLine($"tip amount: {Tip}");
            Console.WriteLine($"total amount: {Total}");
        }
    }
}