using MagicNumbers.Controllers;
using MagicNumbers.Views;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MagicNumbers
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Thread winFormThread = new Thread(() =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MagicNumberForm());
            });

            winFormThread.Start();

            MagicNumberController magicNumber = new MagicNumberController(useConsole: true);

            winFormThread.Join();
        }
    }
}