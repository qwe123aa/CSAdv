using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value) {
            Value = value;
        }
    }

    class Needed<T, U>
    {
        public T Value1;
        public U Value2;
        public Needed(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<int> wantedInt = new Wanted<int>(65535);
            Wanted<string> wantedString = new Wanted<string>("Hello, World");
            Wanted<double> wantedDouble = new Wanted<double>(3.141592);

            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedDouble.Value);
        }
    }
}
