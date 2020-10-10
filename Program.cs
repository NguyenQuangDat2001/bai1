using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace bai1
{
    class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = 0;
            y = 0;          
        }
        public Diem(double ox,double oy)
        {
            x = ox;
            y = oy;
        }
        public void nhap()
        {
            Console.Write("nhap toa do x : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("nhap toa do y : ");
            y = int.Parse(Console.ReadLine());
        }
        public double tinhKC(Diem A)
        {
            return Math.Sqrt(Math.Pow(A.x - this.x, 2) + Math.Pow(A.y - this.y, 2));
        
        }
        public void hien()
        {
            Console.WriteLine("toa do diem can tinh ({0},{1})", x, y);
        }
    }
    class Program
    {
        static void Main()
        {
            Diem t = new Diem();
            t.nhap();
            t.hien();
            
        }
    }
}
