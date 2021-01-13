using System;
using System.Net;
using System.Text.RegularExpressions;

namespace bai3c2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] SinhVien = new string[10];
            bool ktra = false;
            string sv;
            Console.WriteLine("Thong tin sinh vien co dang hoten;dd/mm/yy;quequan;lop");
            Console.WriteLine("For example: Nguyen Van A;01/11/2000;Ha Noi;CNTT17\n");
            
            for(int i=0; i<10; i++)
            {
                do
                {
                    Console.WriteLine("nhap thong tin sinh vien {0}: ", +(i+1));
                    sv = Console.ReadLine();
                    ktra = Regex.IsMatch(sv, @"^([A-Z][a-z]*)(\s[A-Z][a-z]*)*;((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19[5-9][1-9]|(2));([A-Z][a-z]*)(\s[A-Z][a-z]*)*;([A-Z]+\d+)$");
                } while (ktra == false);
                SinhVien[i] = sv;
            }
            int dem = 0;
            for(int i = 0; i < 10; i++)
            {
                string[] thongTin = SinhVien[i].Split(";");
                string[] ngaySinh = thongTin[1].Split("/");

                int namSinh = Convert.ToInt32(ngaySinh[2]);
                int tuoi = 2020 - namSinh;
                if(tuoi>=19 && tuoi <= 22)
                {
                    dem++;
                }
            }
            Console.WriteLine("so sinh vien tu 19- 22 la: " +dem);
        }
    }
}
