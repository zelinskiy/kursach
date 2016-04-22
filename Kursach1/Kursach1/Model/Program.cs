﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach1.Model;

namespace Kursach1
{

    

    static class Program
    {


        public static Prisoners MyPrison = new Prisoners();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 




        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnApplicationExit);
            Application.Run(new MainForm(MyPrison));
            
        }

        public static void OnApplicationExit(object sender, EventArgs e)
        {
            MyPrison.Save();
        }

    }
}
