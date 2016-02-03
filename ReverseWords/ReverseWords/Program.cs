using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(Program.reverseSentence("My name is Ghebre"));
            Console.ReadLine();
        }

        public static string reverseSentence(string sent)
        {
            //a method that takes in a string and reverses the words as an output
            string[] words = sent.Split(' ');
            Array.Reverse(words);

            return string.Join(" ", words);
        }
             
            

         
    }
}
