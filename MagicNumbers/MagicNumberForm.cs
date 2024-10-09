using System;
using System.Windows.Forms;
using MagicNumbers.Controllers;

namespace MagicNumbers.Views
{
    public partial class MagicNumberForm : Form
    {
        private MagicNumberController magicNumberController;

        public MagicNumberForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int magicNumber))
            {
                txtOutput.Clear();
                magicNumberController = new MagicNumberController(magicNumber, DisplayMagicNumber);
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void DisplayMagicNumber(string number)
        {
            txtOutput.Invoke(new Action(() => txtOutput.AppendText(number + " ")));
        }
    }
}
