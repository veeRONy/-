using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using p_ch_m_i.Models;
using p_ch_m_i.Controllers;
using System.Configuration;
using System.ComponentModel.Design;

namespace p_ch_m_i
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}