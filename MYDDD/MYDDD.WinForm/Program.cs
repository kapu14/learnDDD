using System;
using System.Windows.Forms;
using MYDDD.WinForm.Views;

namespace MYDDD.WinForm
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WeatherLatestView());
        }
    }
}
