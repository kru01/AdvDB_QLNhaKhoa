using QLNhaKhoa.Admin_form;
using QLNhaKhoa.Dentist_form;
using QLNhaKhoa.Employee_form;
using System.Data.SqlClient;

namespace QLNhaKhoa
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
            // see https://aka.ms/applicationconfigurati
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}