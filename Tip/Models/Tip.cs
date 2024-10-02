using System;

namespace TipApp.Models
{
    public class Tip
    {
        private double sumOrder;
        private double percentage;

        public double SumOrder
        {
            get { return this.sumOrder; }
            set { this.sumOrder = value; }
        }

        public double Percentage
        {
            get { return this.percentage; }
            set 
            { 
                if (value > 1) {
                    this.percentage = value / 100;
                }
                else
                {
                    this.percentage = value;
                }
            }
        }

        public double CalculateTip()
        {
            return this.Percentage * this.SumOrder;
        }

        public double CalculateTotal()
        {
            return this.sumOrder + CalculateTip();
        }

        public Tip(double sumOrder, double percentage)
        {
            this.SumOrder = sumOrder;
            this.Percentage = percentage;
        }
    }
}