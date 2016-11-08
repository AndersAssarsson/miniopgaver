using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniopgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("------------------------");

            Opgave1();
            Opgave2();
            Opgave3();
            Opgave4();
            //Opgave5();

            Debug.WriteLine("------------------------");

        }
     
        static void Opgave1()
        {
            Debug.WriteLine("Hello");
            Debug.WriteLine("Anders Assarsson");
        }

        static void Opgave2()
        {
            int x = 15 + 133;
            Debug.WriteLine(x);
        }

        private static void Opgave3()
        {
            int x = 24 / 5;
            Debug.WriteLine(x);
        }

        private static void Opgave4()
        {
            int x = -1 + 3 * 5;
            Debug.WriteLine(x);
            int y = (24 + 5) % 7;
            Debug.WriteLine(y);
            float z = 15 + -4 * 6 / 11f;
            Debug.WriteLine(z);
            float w = 2 + 10 / 6 * 1 - 7 % 2f;
            Debug.WriteLine(w);
        }

        private static void Opgave5()
        {

        }
}
