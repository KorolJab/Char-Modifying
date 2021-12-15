
using System.IO;
using System;
using System.Net;
using System.Text;

namespace SimpleReplacingAlgorythm
{
    class Programm
    {
        static void Main()
        {
            Replacer replacement = new Replacer();
            string smth = replacement.ReplaceChar(Console.ReadLine());
            Console.WriteLine(smth);

            
        } 
                
    }
}