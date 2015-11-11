using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GymFitnessOlympic.View;
using GymFitnessOlympic.View.MainForms;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.View.ActForm.ThongKe;
using GymFitnessOlympic.View.ActForm;
using TanHongPhat;
using System.Threading;
using System.Globalization;
using RawInput;
namespace GymFitnessOlympic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmCheckinNhanVien() );
            // // C#
            // Put the using statements at the beginning of the code module

            // Put the following code before InitializeComponent()
            // Sets the culture to French (France)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            Application.Run(new MainForm());
            //Application.Run(new FrmCheckinNhanVien());
            //Application.Run(new FrmQLyNhanVien());
        }
    }
}
