using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventpuzzle
{
    internal class Day_One
    {
        public Day_One() { }

        public static void Solve()
        {
            StreamReader sr = new StreamReader("C:\\Users\\uzivatel\\Desktop\\cisla.txt");

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] cisla = line.Split(' ');
                left.Add(int.Parse(cisla[0]));
                right.Add(int.Parse(cisla[3]));

            }

            int o = 0;
            int p = 0;

            left.Sort();
            right.Sort();

            foreach (int c in left)
            {
                int a = left.IndexOf(c);
                o += Math.Abs(c - right[a]);
                Console.WriteLine(c + " x " + right[a]);
            }

            Console.WriteLine(o);
        }
    }
}
