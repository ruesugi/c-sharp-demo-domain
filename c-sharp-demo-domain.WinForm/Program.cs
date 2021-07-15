using c_sharp_demo_domain.WinForm.Views;
using System;
using System.Windows.Forms;

namespace c_sharp_demo.WinForm
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
            Application.Run(new MenuView());
        }
    }
}
