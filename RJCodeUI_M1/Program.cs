using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeUI_M1
{
    static class Program
    {
        /* Note: When executing the application from visual studio, the configuration file is saved 
                 * in the folder RJCodeUI_M1.vshost.exe. And when restarting the application the configuration
                 * file is obtained from the RJCodeUI_M1.exe folder, since after restarting the application it
                 * runs independently of visual studio, so it will not load the settings you established on the 
                 * first restart since it will take the file of RJCodeUI_M1.exe configuration. If you want to 
                 * test and apply the settings established when you are developing the application, I recommend 
                 * you close the application (or stop debugging) and rerun from visual studio or compile the project
                 * and run the application directly from the project's bin folder.*/

        //Fields
        public static Form MainForm;//Gets or sets the primary form of the application

        //Main method
        [STAThread]
        static void Main()
        {
            Settings.SettingsManager.LoadApperanceSettings();//Load current appearance settings.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm = new MainForm());//Run form

        }
    }
}
