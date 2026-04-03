using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            Console.ReadKey();
        }
        static void ReadFile()
        {
            string filename = "D:\\工作\\大二\\编程\\C#\\data\\BL.txt";
            var reader = new StreamReader(filename);
            string buf = reader.ReadLine();
            int[] number = new int[4];
            string[] siteName = new string[4];
            double[] B = new double[4];
            double[] L = new double[4];
            for(int i = 0; i < 4; i++)
            {
                buf = reader.ReadLine();
                var arr = buf.Split(' ');
                number[i] = int.Parse(arr[0]);
                siteName[i] = arr[1];
                B[i] = Convert.ToDouble(arr[2]);
                L[i] = double.Parse(arr[3]);
                Console.WriteLine("{0} {1}", siteName[i], L[i]);
            }    

            reader.Close();
        }

    }
}
