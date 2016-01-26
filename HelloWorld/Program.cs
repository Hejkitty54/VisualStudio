using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Practice
    {
        public delegate int Multipier(int i);
        public delegate int MultipierTwo(int i, int y);
        public delegate int IntTransformer(int i);


        public delegate int LsString(string s);

        static void Main(string[] args)

        {
            Multipier f1 = i => i * 2;
            Multipier f2 = i => i * i;

            LsString lengthOfstring = s => s.Length;

            Func<string, int> f = x => x.Length;

            int[] array = new int[] { 4, 6, 7, -2, 47 };

            int[] doubled = DoubleElements(array);
            //kan användas på många olika sätt
            int[] timesThree = MapElements(array, x => x*3);


            string[] ss = new string[] { "hello", "world", "kkk" };

            //Console.WriteLine (MaxString (ss,lengthOfstring));

            //Console.WriteLine (f1 (5));

            //Console.WriteLine (DoFiveTimes(2,f1));
            Console.WriteLine(String.Join(",", doubled));

        }

        static int DoFiveTimes(int i, Multipier f)
        {
            return f(f(f(f(f(i)))));
        }

        static int DoNTimes(int i, int n, Multipier f)
        {

            int value = i;
            for (int x = 0; x < n; x++) 
            {
                value = f(value);
            }
            return value;
        }

        static int[] DoubleElements(int[] input)
        {
            int[] output = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
               output[i] = input[i] * 2;
            }
            return output;
        }

        static int[] MapElements(int[] input, IntTransformer f)
        {
            int[] output = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = f(input[i]);
            }
            return output;
        }


        /*

        static string MaxString(string[] s, LsString l)

        {

            int max = 0;



            for(int i=0; i<s.Length; i++)

            {

                if(l (s[i]) > max)

                    max= l (s[i]);

            }

            return s[0];

        }*/

    }


}
