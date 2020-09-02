using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.AppendLine("This is the second line. ");
            sb.Append(".");

            Console.WriteLine(sb.ToString());
        }
    }
}
