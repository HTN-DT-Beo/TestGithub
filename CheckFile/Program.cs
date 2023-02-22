using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CheckFile
{
    class Program
    {
        FileInfo testFile = new FileInfo("D:/Programming/test.txt");
        public void infoFile()
        {
            if (testFile.Exists)
            {
                Console.WriteLine(testFile.FullName + " exist ");
                //Thông tin thời điểm tạo file
                Console.WriteLine("Createtion time: " + testFile.CreationTime);
                //Thông tin thời điểm file được sửa đổi lần cuối.
                Console.WriteLine("Last Write Time " + testFile.LastWriteTime);
                //Tên thư mục chứa file này.
                Console.WriteLine("Directory Name: " + testFile.DirectoryName);

            }
            else
            {
                Console.WriteLine(testFile.FullName + "does not exist");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bui Duc Nhan_21133060\n");

            Program pg = new Program();
            pg.infoFile();

            Console.ReadLine();
        }
    }
}
