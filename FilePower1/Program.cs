using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
       private static void Main(string[] args)
        {
            string input_path = args[0];
            string input_string;
            bool input_loop = true;
            Queue<string> str_Queue = new Queue<string>();

             while(input_loop == true)
            {
                input_string = Console.ReadLine();

                if(input_string == "")
                {
                    input_loop = false;
                }
                else
                {
                    str_Queue.Enqueue(input_string);
                }
            }
            File.WriteAllLines(input_path, str_Queue);
        }
    }
}