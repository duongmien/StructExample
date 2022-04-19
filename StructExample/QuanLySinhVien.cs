using System;
using System.Collections.Generic;
using System.Text;

namespace StructExample
{
    class QuanLySinhVien
    {
            public struct sinhvien
            {
                public string hoten_234;
                public string msv_234;
                public double toan_234;
                public double ly_234;
                public string age_234;
                public string className_234;
                public double hoa_234;
                public gioitinh gioitinh_234;


        };
            
            public enum hocluc
            {
                Yeu,
                TrungBinh,
                Kha,
                Gioi
            };
           public enum gioitinh
            {
                Nam,
                Nu
            };
            public static void nhapSinhVien(ref sinhvien[] sv, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                    Console.Write("Ho ten sinh vien: ");
                    string ht_234 = Console.ReadLine();
                    Console.Write("Ma sinh vien: ");
                    string msv_234 = Console.ReadLine();
                    Console.Write("Gioi tinh (0: nam  1: nu): ");
                    int gt_234 = int.Parse(Console.ReadLine());
                    Console.Write("Lop sinh vien: ");
                    string className = Console.ReadLine();
                    Console.Write("Tuoi sinh vien: ");
                    string age = Console.ReadLine();
                    Console.Write("Diem toan: ");
                    double dt_234 = double.Parse(Console.ReadLine());
                    Console.Write("Diem ly: ");
                    double dl_234 = double.Parse(Console.ReadLine());
                    Console.Write("Diem hoa: ");
                    double dh_234 = double.Parse(Console.ReadLine());


                    sv[i].hoten_234 = ht_234;
                    sv[i].msv_234 = msv_234;
                    
                    if (gt_234 == 0)
                        sv[i].gioitinh_234 = gioitinh.Nam;
                    else
                        sv[i].gioitinh_234 = gioitinh.Nu;
                        sv[i].className_234 = className;
                        sv[i].age_234 = age;
                        sv[i].toan_234 = dt_234;
                        sv[i].ly_234 = dl_234;
                        sv[i].hoa_234 = dh_234;

                }
            }
            public static hocluc mediumScore(double toan, double ly, double hoa)
            {
                double dtb = (toan + ly + hoa) / 3;
                if (dtb <= 4)
                    return hocluc.Yeu;
                else if (dtb <= 5)
                    return hocluc.TrungBinh;
                else if (dtb <= 7)
                    return hocluc.Kha;
                else
                    return hocluc.Gioi;
            }
            public static void xuatSinhVien(sinhvien[] sv, int n)
            {
                int i = 1;
                foreach (sinhvien item_234 in sv)
                {
                    Console.WriteLine("----- " + i + " -----");
                    Console.WriteLine("Ho ten: " + item_234.hoten_234);
                    Console.WriteLine("Ma sinh vien: " + item_234.msv_234);
                    int gt = (int)item_234.gioitinh_234;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                       Console.WriteLine("Gioi tinh: Nu");
                    Console.WriteLine("Lop Sinh Vien: " + item_234.className_234);
                    Console.WriteLine("Tuoi Sinh Vien: " + item_234.age_234);
                    Console.WriteLine("Diem toan: " + item_234.toan_234);
                    Console.WriteLine("Diem ly: " + item_234.ly_234);
                    Console.WriteLine("Diem hoa: " + item_234.hoa_234);
                    int hocluc = (int)mediumScore(item_234.toan_234, item_234.ly_234, item_234.hoa_234);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }

                    i++;
                }
            }
            public static void findByName(sinhvien[] sv, int n, string ht)
            {
                foreach (sinhvien item_234 in sv)
                {
                    if (item_234.hoten_234 == ht)
                    {
                        Console.WriteLine("Ho ten: " + item_234.hoten_234);
                        Console.WriteLine("Ma sinh vien: " + item_234.msv_234);
                        int gt = (int)item_234.gioitinh_234;
                        if (gt == 0)
                            Console.WriteLine("Gioi tinh: Nam");
                        else
                            Console.WriteLine("Gioi tinh: Nữ");
                        Console.WriteLine("Diem toan: " + item_234.toan_234);
                        Console.WriteLine("Lop Sinh Vien: " + item_234.className_234);
                        Console.WriteLine("Tuoi Sinh Vien: " + item_234.age_234);
                        Console.WriteLine("Diem ly: " + item_234.ly_234);
                        Console.WriteLine("Diem hoa: " + item_234.hoa_234);
                        int hocluc = (int)mediumScore(item_234.toan_234, item_234.ly_234, item_234.hoa_234);
                        switch (hocluc)
                        {
                            case 0:
                                Console.WriteLine("Hoc luc: Yeu");
                                break;
                            case 1:
                                Console.WriteLine("Hoc luc: Trung Binh");
                                break;
                            case 2:
                                Console.WriteLine("Hoc luc: Kha");
                                break;
                            case 3:
                                Console.WriteLine("Hoc luc:Gioi");
                                break;

                        }
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.Write("Nhap so luong sinh vien: ");
                int n_234 = int.Parse(Console.ReadLine());
                sinhvien[] sv_234 = new sinhvien[n_234];
                nhapSinhVien(ref sv_234, n_234);
                Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
                xuatSinhVien(sv_234, n_234);

                Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
                Console.Write("Nhap ten sinh vien: ");
                string ht_234 = Console.ReadLine();
                findByName(sv_234, n_234, ht_234);
                Console.ReadLine();
            }

    }
}