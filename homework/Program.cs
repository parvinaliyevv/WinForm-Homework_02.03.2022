using System;
using System.Windows.Forms;
using homework.Views;

namespace homework
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainView();
            new Presents.MainPresenter(view);

            Application.Run(view);
        }
    }
}
