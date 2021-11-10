using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanD6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            if(n <= 0 ||n > 10)
            {
                Console.WriteLine("Nhap so tu 1 den n < 10");
                Console.ReadKey();
                return;
            }
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
            // In ra man hinh array random
            Console.WriteLine("Xuat day so vua khoi tao ra man hinh");
            Print(arr);
            var arrayNguyenDuong = arr.Where(x => x >= 0).ToArray();
            Console.WriteLine("\nXuat day so nguyen duong");
            Print(arrayNguyenDuong);
            var arrayTang = arr.OrderBy(x => x).ToArray();
            Console.WriteLine("\nXuat day so ra man hinh theo thu tu tang dan");
            Print(arrayTang);
            var arrayGiam = arr.OrderByDescending(x => x).ToArray();
            Console.WriteLine("\nXuat day so ra man hinh theo thu tu giam dan");
            Print(arrayGiam);
            Console.ReadKey();
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
