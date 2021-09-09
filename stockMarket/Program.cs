using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var read=new StreamReader(@"C:\Users\Sricharani Aleti\Downloads\Computershare - Coding Challenge\ChallengeSampleDataSet1.csv"))
            {
                String[] values = { };
                while (!read.EndOfStream)
                {
                    Console.WriteLine("enter something");
                    var data = read.ReadLine();
                    Console.WriteLine(data);
                    values = data.Split(',');
                    Console.WriteLine(values[0]);
                }
                Console.WriteLine(values);
                float diff = 0;
                float result1 = 0;
                int max1 = 0;
                int min1 = 0;
                for (int i = 0; i < values.Length; i++)
                {
                   
                    int maxindex = i+1;
                    int minindex = i;
                    for(int j = i+1; j < values.Length - 1; j++)
                    {
                        if((float.Parse(values[j])-float.Parse(values[i])) > diff)
                        {
                            diff = float.Parse(values[j]) - float.Parse(values[i]);
                            maxindex = j;
                            minindex = i;
                        }
                    }
                    
                    if (diff > result1)
                    {
                        result1 = diff;
                        max1 = maxindex;
                        min1 = minindex;
                    }

                }
                int x = max1 + 1;
                Console.WriteLine(min1+1+"("+values[(int)(min1)]+"),"+x+"("+values[(int)max1]+")");
            }
        }
    }
}
