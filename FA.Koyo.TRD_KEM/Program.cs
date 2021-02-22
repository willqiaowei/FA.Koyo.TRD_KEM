using FA.Koyo.TRD_KEM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Loading loading = new Loading();//先运行初始化界面
            loading.ShowDialog();
            if (loading.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm()); //初始化成功进入主界面
            }
            else
            {
                return;
            }

            //Application.Run(new MainForm());
        }
    }
}
