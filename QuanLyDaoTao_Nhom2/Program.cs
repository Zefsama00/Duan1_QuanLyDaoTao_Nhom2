using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SinhVien());
            //Application.Run(new QuanLySinhVien());
            //Application.Run(new Diem());
            //Application.Run(new LichDay());
            //Application.Run(new LichHoc());
            Application.Run(new Nganh());
        }
    }
}
