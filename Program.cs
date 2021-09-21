using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneotomasyon
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new login());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // Application.Run(new Form1());

        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)

        {
            Application.Run(new yöneticiris());
            Application.Run(new Form1());
            Application.Run(new Form1Hastakayıt());
            Application.Run(new Form2());
            Application.Run(new doktorgiris());
        }
    }
}
