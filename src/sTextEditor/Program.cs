using System;
using System.Reflection;
using System.Windows.Forms;
using ReactiveUI;
using Splat;

namespace sTextEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var bootstrapper = new AppBootstrapper();
            bootstrapper.Run();
        }
    }
}
