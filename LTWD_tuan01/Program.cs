using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanHe quanHe = new QuanHe();

            //Truyền 2 tham số vào ham TImMoiQuanHe(...) để tìm quan hệ
            //Chú ý: đến thứ tự truyền tham số, nếu báo lỗi hãy đảo lại thứ tự
            string ketQua = quanHe.TImMoiQuanHe(DoiTuong.arrayTamGiac[1], DoiTuong.arrayTron[1]);
            Console.WriteLine(ketQua);

            Console.ReadLine();
        }
       
    }
}
