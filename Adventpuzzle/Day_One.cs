using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
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

            int distance = 0;
            int similarity_score = 0;
            int mul = 0;

            left.Sort();
            right.Sort();

            //Total distance
            foreach (int c in left)
            {
                int a = left.IndexOf(c);
                distance += Math.Abs(c - right[a]);
                Console.WriteLine(c + " x " + right[a]);
            }

            foreach (int c in left) {
                
                int a = left.IndexOf(c);
                foreach (int b in right)
                {
                    if (b.Equals(c)) mul++;
                }

                similarity_score += (c * mul);
                mul = 0;
            }

            Console.WriteLine("Similarity: " + similarity_score);
            Console.WriteLine("Distance: " + distance);
         
        }
    }
}
