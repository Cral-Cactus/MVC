using System;

namespace TipApp.Models
{
    public class Tip
    {
        private double sumOrder;
        private double percentage;

        public double SumOrder
        {
            get { return sumOrder; }
            set { sumOrder = value; }
        }

        public double Percentage
        {
            get { return percentage; }
            set 
            { 
                if (value > 1) {
                    percentage = value / 100;
                }
                else
                {
                    percentage = value;
                }
            }
        }

        public double CalculateTip()
        {
            return Percentage * SumOrder;
        }

        public double CalculateTotal()
        {
            return sumOrder + CalculateTip();
        }

        public Tip(double sumOrder, double percentage)
        {
            this.SumOrder = sumOrder;
            this.Percentage = percentage;
        }
    }
}