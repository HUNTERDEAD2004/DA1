using AppData.Models;
using PRL.View;

namespace PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //HDCT hdctform = new HDCT();
            //Orderform orderform = new Orderform(hdctform);

            //orderform.Show();
            //Application.Run();


            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

    }
}