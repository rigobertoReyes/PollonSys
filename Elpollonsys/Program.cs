﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Elpollonsys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string nombredeusuario = "";
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Form1 form = new Form1();
            form.Show();
            Application.Run();
        }
    }
}
