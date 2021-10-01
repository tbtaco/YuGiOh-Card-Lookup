using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOh_Card_Lookup
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
            try
            {
                Application.Run(new UserInterface());
            }
            catch (Exception /*e*/)
            {
                //MessageBox.Show(e.Message+"\n"+e.Source+"\n"+e.StackTrace);
            }
        }
    }
}
