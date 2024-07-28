using DAL.Models;
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

            HDCT hdctForm = new HDCT();
            Order orderForm = new Order(hdctForm);

            orderForm.Show();

            Application.Run();
        }

    }
}