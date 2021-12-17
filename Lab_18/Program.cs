using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18
{
    class Program
    {
        static bool BracketCheck(string s)
        {
            string t = "[{(]})";
            Stack<char> st = new Stack<char>();

            foreach (var x in s)
            {
                int f = t.IndexOf(x);

                if (f >= 0 && f <= 2)
                    st.Push(x);

                if (f > 2)
                {
                    if (st.Count == 0 || st.Pop() != t[f - 3])
                        return false;
                }
            }

            if (st.Count != 0)
                return false;

            return true;
        }

        static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(BracketCheck(s) ? "верно" : "не верно");
            Console.ReadKey();
        }
    }
}