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
            set { percentage = value; }
        }

        public double CalculateTotal()
        {
            return sumOrder + (percentage * sumOrder);
        }

        public Tip(double sumOrder, double percentage)
        {
            this.sumOrder = sumOrder;
            this.percentage = percentage;
        }
    }
}