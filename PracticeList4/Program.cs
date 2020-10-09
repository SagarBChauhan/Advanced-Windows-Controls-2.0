using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PracticeList4
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
            //Application.Run(new Leave());
          //  Application.Run(new Enrollment());
          // Application.Run(new Product());
           // Application.Run(new medicines());
         //   Application.Run(new StudentScore());
          // Application.Run(new JobMaster());
            //  Application.Run(new restaurant());
            Application.Run(new Search());
        }
    }
}
