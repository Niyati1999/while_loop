using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("print Numbers using while:");
            /*while(i <= 5){
                Console.WriteLine(i);
                i++;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);*/
            string data = "we will do it";
            int l = data.Length;
            Console.WriteLine("Length = " + l);
            char ch = data[0];
            Console.WriteLine(ch);
            for(int i = 0; i < l; i++)
            {
                char a = data[i];
                Console.WriteLine(a);
            }
        }
        }
    }

