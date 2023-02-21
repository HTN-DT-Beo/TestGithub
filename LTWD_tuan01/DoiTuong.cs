using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DoiTuong
    {
        //Tạo đối tượng các hình, truyền tham số cho các điểm trong hình theo tọa độ x, y
        public static TamGiac tamGiac01 = new TamGiac(1, -2, 2, 1, -1, 5);
        public static TamGiac tamGiac02 = new TamGiac(0, 2, 2, 0, 0, 0);
        public static HinhVuong hinhVuong = new HinhVuong(0, 2, 2, 2, 2, 0, 0, 0);
        public static HinhChuNhat hinhCn = new HinhChuNhat(0, 2, 2, 2, 2, 0, 0, 0);
        public static HinhTron hinhTron01 = new HinhTron(4, 10, 9);
        public static HinhTron hinhTron02 = new HinhTron(2, 1, 1);
        public static DuongThang duongThang01 = new DuongThang(3, -4, -21);
        public static DuongThang duongThang02 = new DuongThang(3, -5, -5);
        public static ToaDo diem = new ToaDo(2 / 3, 1);

        //Tạo mảng chứa các đối tượng tương ứng
        public static TamGiac[] arrayTamGiac = new TamGiac[] { tamGiac01, tamGiac02 };
        public static TuGiacDacBiet[] arrayTuGiac = new TuGiacDacBiet[] { hinhCn, hinhVuong };
        public static HinhTron[] arrayTron = new HinhTron[] { hinhTron01, hinhTron02 };
        public static DuongThang[] arrayDuongThang = new DuongThang[] { duongThang01, duongThang02 };
        public static ToaDo[] arrayDiem = new ToaDo[] { diem };
    }
}
