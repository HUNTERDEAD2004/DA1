using AppData.Models;
using PRL.View;
using System.Globalization;

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
            // Đặt văn hóa mặc định thành tiếng Việt
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
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