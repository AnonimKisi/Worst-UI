using System;
using System.Windows.Forms;

namespace Worst_UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Worst_UI());
        }
    }
}
