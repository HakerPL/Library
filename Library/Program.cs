using System;
using System.Windows.Forms;
using Autofac;
using DiAutofac;
using MySQL;
using MySQL.Repositories;
using View.Library;

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


            DiContainer.Container.Resolve<ConnectDb>();
            DiContainer.Container.Resolve<AuthorRepository>();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
