using ProjectSharp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSharp
{
    static class Program
    {
        static Form1 form;
        

        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            form.Categories.WriteListToFile();    
            form = new Form1();
            Application.Run(form);
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            form.FileHandler.SaveFeed();
        }

    }
}
