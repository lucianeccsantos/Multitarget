using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Standard.Class1.MyString()} - netstandard2.0;net461");
            Console.WriteLine($"{Standard.Class1.MyStringCore()} - netcoreapp2.0;netstandard2.0");
            Console.WriteLine($"{Standard.Class1.MyStringCore2()} - netcoreapp2.2;netstandard2.0");
            Console.ReadKey();
        }
    }
}
