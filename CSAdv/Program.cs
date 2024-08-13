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

    class SpecialNeeded<T, U>
        where T : IComparable
        where U : IComparable, IDisposable
    {
        public T Value1;
        public U Value2;
        
        public SpecialNeeded(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }

    class SquareCalculator  
    {
        public int this[int i]  //Indexer
        {
            get { return i * i; }
        }
    }

    internal class Program
    {
        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            Wanted<int> wantedInt = new Wanted<int>(65535);
            Wanted<string> wantedString = new Wanted<string>("Hello, World");
            Wanted<double> wantedDouble = new Wanted<double>(3.141592);

            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedDouble.Value);

            SquareCalculator s = new SquareCalculator();
            Console.WriteLine(s[256]);

            Console.Write("숫자 입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자 : " + output);
            }else
            {
                Console.WriteLine("숫자를 입력해주세요");
            }

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine("현재좌표  x : {0}, y : {1}", x, y);
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음좌표  x : {0}, y : {1}", x, y);
        }
    }
}
