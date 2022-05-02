using Marfrig.Models;
using Marfrig.Presenters;
using Marfrig.Repository;
using Marfrig.Views;
using Marfrig._Repositories;
using System.Configuration;

namespace Marfrig
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Marfrig.SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString); 

            Application.Run((Form)view);
        }
    }
}  