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
            magicNumberController = new MagicNumberController(useConsole: false);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int magicNumber))
            {
                txtOutput.Clear();
                magicNumberController.ProcessMagicNumber(magicNumber);
                magicNumberController.SetOutputForWinForms(this);
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        public void DisplayMagicNumber(string output)
        {
            txtOutput.AppendText(output);
        }
    }
}
