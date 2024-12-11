using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventpuzzle
{
    internal class Day_two
    {
        public Day_two() { }

        public static void Solve()
        {
            StreamReader sr = new StreamReader("C:\\Users\\uzivatel\\Desktop\\AOc\\2.txt");

            string line = "";
            int safe = 0;

            while ((line = sr.ReadLine()) != null)
            {
                string sortedup = "";
                string sorteddown = "";
                string listToCompare = "";
                int last = 0;

                bool safety = false;
                //populates list of numbers
                string[] numbers = line.Split(' ');
                List<int> list = new List<int>();
                List<int> sorter = new List<int>();
                foreach (string s in numbers)
                {
                    list.Add(int.Parse(s));
                    sorter.Add(int.Parse(s));
                    //listToCompare += s + " ";
                }

                /*Dumb solution to first part
                sorter = list;
                sorter.Sort();
                              

                foreach (int a in sorter) {
                    sortedup += a + " ";
                    last = a;
                }

                sorter.Reverse();
                foreach (int b in sorter)
                {
                    sorteddown += b + " ";
                }

                if (listToCompare.Equals(sorteddown) || listToCompare.Equals(sortedup))
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        if (((Math.Abs((list[i] - list[i + 1])) > 0) && (Math.Abs((list[i] - list[i + 1])) <= 3)) || wrong <=1)
                        {
                            safety = true;
                        }
                        else
                        {
                            safety = false;
                            wrong++;
                        }
                    }
                }
                else safety = false;
                 */

                int wrong = 0;
                sorter.Sort();

                for(int i = 0; i < sorter.Count; i++)
                {
                   if (sorter[i] == list[i]) 
                   {
                        continue;
                   }
                   else wrong++;
                }wrong--;

                if (!(wrong <2)) {
                    wrong = 0;
                    sorter.Reverse();
                    for (int i = 0; i < sorter.Count; i++)
                    {
                        if (sorter[i] == list[i])
                        {
                            continue;
                        }
                        else wrong++;
                    }
                }

                if (wrong < 2)
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        if ((Math.Abs((list[i] - list[i + 1])) > 0) && (Math.Abs((list[i] - list[i + 1])) <= 3))
                        {
                            safety = true;
                        }
                        else
                        {
                            safety = false;
                            break;
                        }
                    }
                }else safety = false;

                if (safety != false) safe++;
            }

            Console.WriteLine(safe.ToString());
        }
    }
}
