using System;
using System.Windows.Forms;

namespace sTextEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();            
        }
    }
}
