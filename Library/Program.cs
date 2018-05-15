using System;
using System.Windows.Forms;
using Autofac;
using DiAutofac;
using Library.View;
using MySQL;
using MySQL.Repositories;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DiContainer.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
