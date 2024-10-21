using System;

namespace MagicNumbers.Views
{
    public class DisplayWinForms : Display
    {
        public MagicNumberForm Form { get; set; }

        public override void DisplayMagicNumber()
        {
            Form.Invoke(new Action(() => Form.txtOutput.AppendText(Output)));
        }
    }
}