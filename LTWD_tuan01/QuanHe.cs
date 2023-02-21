using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class QuanHe
    {
        public QuanHe() { }

        /*** Method TImMoiQuanHe được overload nhiều lần ***/

        public void TinhChuViDienTich(HinhHoc hinh01, HinhHoc hinh02)
        {
            Console.WriteLine("Diện tích 2 hình lần lượt là: " + hinh01.DienTich() + ", " + hinh02.DienTich());
            Console.WriteLine("Chu vi 2 hình lần lượt là: " + hinh01.ChuVi() + ", " + hinh02.ChuVi());
        }
        public string TImMoiQuanHe(HinhTron hinhTron, DuongThang duongThang)
        {
            double kCach = HinhHoc.KcDiemDenDuong(duongThang, hinhTron.Tam);
            //Tính diện tích, chu vi
            TinhChuViDienTich(hinhTron, duongThang);
            //Tìm mối quan hệ
            if (kCach < hinhTron.R)
            {
                return "Vậy đường thẳng cắt hình tròn tại hai điểm";
            }
            else if (kCach > hinhTron.R)
            {
                return "Vậy đường thẳng nầm rời nhau hình tròn";
            }
           
            return "Vậy đường thẳng tiếp xúc hình tròn tại một điểm";
        }
        public string TImMoiQuanHe(HinhTron hinhTron, ToaDo diem)
        {
            double doDaiDoanThang = HinhHoc.kCachHaiDiem(hinhTron.Tam, diem);
            //Tính diện tích, chu vi
            TinhChuViDienTich(hinhTron, diem);
            //Tìm mối quan hệ
            if (doDaiDoanThang <= hinhTron.R)
            {
                return "Vay diem thuoc hinh tron";
            }
            return "Vay diem KHONG thuoc hinh tron";
        }
        public string TImMoiQuanHe(TuGiacDacBiet tuGiac, HinhTron hinhTron)
        {
            double OA = HinhHoc.kCachHaiDiem(hinhTron.Tam, tuGiac.DinhA);
            double OB = HinhHoc.kCachHaiDiem(hinhTron.Tam, tuGiac.DinhB);
            double OC = HinhHoc.kCachHaiDiem(hinhTron.Tam, tuGiac.DinhC);
            double OD = HinhHoc.kCachHaiDiem(hinhTron.Tam, tuGiac.DinhD);
            double BC = HinhHoc.kCachHaiDiem(tuGiac.DinhB, tuGiac.DinhC);
            double CD = HinhHoc.kCachHaiDiem(tuGiac.DinhC, tuGiac.DinhD);
            double AB = HinhHoc.kCachHaiDiem(tuGiac.DinhA, tuGiac.DinhB);
            double AD = HinhHoc.kCachHaiDiem(tuGiac.DinhA, tuGiac.DinhD);

            //Tính diện tích, chu vi
            TinhChuViDienTich(tuGiac, hinhTron);
            //Tìm mối quan hệ
            if (OA == OB && OB == OC && OC == OD)
            {
                return "Vậy tứ giác nội tiếp đường tròn";
            }
            else if (AB + CD == BC + AD)
            {
                return "Vậy tứ giác ngoại tiếp đường tròn";
            }
            return "Không có mối quan hệ nào";
        }
        public string TImMoiQuanHe(TamGiac tamGiac, HinhTron hinhTron)
        {
            double OC = HinhHoc.kCachHaiDiem(hinhTron.Tam, tamGiac.DinhC);
            double OA = HinhHoc.kCachHaiDiem(hinhTron.Tam, tamGiac.DinhA);
            double OB = HinhHoc.kCachHaiDiem(hinhTron.Tam, tamGiac.DinhB);
            double BC = HinhHoc.kCachHaiDiem(tamGiac.DinhB, tamGiac.DinhC);
            double CA = HinhHoc.kCachHaiDiem(tamGiac.DinhC, tamGiac.DinhA);
            double AB = HinhHoc.kCachHaiDiem(tamGiac.DinhA, tamGiac.DinhB);
            double tempX = (BC*tamGiac.DinhA.X + CA*tamGiac.DinhB.X + AB*tamGiac.DinhC.X) / (BC + AB + CA);
            double tempY = (BC*tamGiac.DinhA.Y + CA*tamGiac.DinhB.Y + AB*tamGiac.DinhC.Y) / (BC + AB + CA);

            //Tính diện tích, chu vi
            TinhChuViDienTich(tamGiac, hinhTron);
            //Tìm mối quan hệ
            if (hinhTron.Tam.X == tempX && hinhTron.Tam.Y == tempY)
            {
                return "Vậy đường tròn nội tiếp tam giác";
            }
            else if (OC == OB && OB == OA)
            {
                return "Vậy đường tròn ngoại tiếp tam giác";
            }
            return "Vậy Không có mối quan hệ nào";
        }
        public string TImMoiQuanHe(TuGiacDacBiet tuGiac, ToaDo diem)
        {
            TamGiac tamGiac01 = new TamGiac(diem.X, diem.Y, tuGiac.DinhA.X, tuGiac.DinhA.Y, tuGiac.DinhB.X, tuGiac.DinhB.Y);
            double area01 = tamGiac01.DienTich();
            TamGiac tamGiac02 = new TamGiac(diem.X, diem.Y, tuGiac.DinhB.X, tuGiac.DinhB.Y, tuGiac.DinhC.X, tuGiac.DinhC.Y);
            double area02 = tamGiac02.DienTich();
            TamGiac tamGiac03 = new TamGiac(diem.X, diem.Y, tuGiac.DinhD.X, tuGiac.DinhD.Y, tuGiac.DinhC.X, tuGiac.DinhC.Y);
            double area03 = tamGiac03.DienTich();
            TamGiac tamGiac04 = new TamGiac(diem.X, diem.Y, tuGiac.DinhA.X, tuGiac.DinhA.Y, tuGiac.DinhD.X, tuGiac.DinhD.Y);
            double area04 = tamGiac04.DienTich();
            double sumOfAreas = area01 + area02 + area03 + area04;

            //Tính diện tích, chu vi
            TinhChuViDienTich(tuGiac, diem);
            //Tìm mối quan hệ
            if (sumOfAreas == tuGiac.DienTich())
            {
                return "Vậy điểm nằm trong tứ giác đặc biệt (hcn/hv)";
            }
            return "Vậy điểm KHÔNG nằm trong tứ giác đặc biệt (hcn/hv)";
        }
        public string TImMoiQuanHe(TamGiac tamGiac, ToaDo diem)
        {
            TamGiac tamGiac01 = new TamGiac(diem.X, diem.Y, tamGiac.DinhA.X, tamGiac.DinhA.Y, tamGiac.DinhB.X, tamGiac.DinhB.Y);
            double area01 = tamGiac01.DienTich();
            TamGiac tamGiac02 = new TamGiac(diem.X, diem.Y, tamGiac.DinhB.X, tamGiac.DinhB.Y, tamGiac.DinhC.X, tamGiac.DinhC.Y);
            double area02 = tamGiac02.DienTich();
            TamGiac tamGiac03 = new TamGiac(diem.X, diem.Y, tamGiac.DinhA.X, tamGiac.DinhA.Y, tamGiac.DinhC.X, tamGiac.DinhC.Y);
            double area03 = tamGiac03.DienTich();
            double sumOfAreas = area01 + area02 + area03;
            //Tính diện tích, chu vi
            TinhChuViDienTich(tamGiac, diem);
            //Tìm mối quan hệ
            if (sumOfAreas == tamGiac.DienTich())
            {
                return "Vậy điểm nằm trong tam giac";
            }
            return "Vậy điểm KHÔNG nằm trong tam giac";
        }
        public string TImMoiQuanHe(DuongThang duongThang, ToaDo diem)
        {
            //Tính diện tích, chu vi
            TinhChuViDienTich(duongThang, diem);
            //Tìm mối quan hệ
            if (HinhHoc.KcDiemDenDuong(duongThang, diem) == 0) 
            {
                return "Điểm thuộc đường thẳng";
            }
            return "Điểm KHÔNG thuộc đường thẳng";
        }
        public string TImMoiQuanHe(HinhTron tron01, HinhTron tron02)
        {
            double tongHaiBanKinh = tron01.R + tron02.R;
            double kcHaiTam = HinhHoc.kCachHaiDiem(tron01.Tam, tron02.Tam);
            //Tính diện tích, chu vi
            TinhChuViDienTich(tron01, tron02);
            //Tỉm mối quan hệ
            if (kcHaiTam == 0 && tron01.R == tron02.R)
            {
                return "Hai hình tròn trùng nhau";
            }
            else if (kcHaiTam < tongHaiBanKinh)
            {
                return "Hai hình tròn giao nhau tai hai diem";
            }
            else if (kcHaiTam > tongHaiBanKinh)
            {
                return "Hai hình tròn rời nhau";
            }
            return "Hai hình tròn tiếp xúc nhau tại một điểm";
        }
        public string TImMoiQuanHe(DaGiac tuGiac01, DaGiac tuGiac02)
        {
            //Tính diện tích, chu vi
            TinhChuViDienTich(tuGiac01, tuGiac02);
            //Tìm mối quan hệ
            return "Không có mối quan hệ nào";
        }
        public string TImMoiQuanHe(DuongThang duong01, DuongThang duong02)
        {
            //Tính diện tích, chu vi
            TinhChuViDienTich(duong01, duong02);
            //Tìm mối quan hệ
            if (duong01.ThamSoA != duong02.ThamSoA)
            {
                return "2 đường thẳng cắt nhau";
            }
            else if (duong01.ThamSoA == duong02.ThamSoA && duong01.ThamSoB == duong02.ThamSoB)
            {
                return "2 đường thẳng trùng nhau";
            }
            return "Không có mối quan hệ nào";
        }
    }
}