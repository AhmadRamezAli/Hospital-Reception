using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
          
             Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Form1());
           // Patient p = new UnInsuredPatient("1", "ahmad", "ali", 3, 4, 5, 6, 7,true);
            //Console.WriteLine(p);
        }
    }
}
