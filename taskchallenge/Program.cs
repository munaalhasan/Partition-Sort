using System;
using System.Collections.Generic;

namespace taskchallenge
{
    class Program
    {
        private static string get_string(string str, int n)
        {
            string temp=" ";
            string sorted = "";
            char prev = str[0];
            List<int> result = new List<int>();

            result.Add(0);
            
            for (int i = 1; i < n; i++)
            {
                if (char.IsDigit(str[i]) != char.IsDigit(prev))
                {
                    result.Add(i);
                }
                prev = str[i];
            }

            //here I add length of string to list
            result.Add(str.Length);

            for (int i = 0; i < result.Count-1 ; i++)
            {
                temp = str.Substring(result[i], result[i+1]- result[i]);
                char[] toChar = temp.ToCharArray();
                Array.Sort(toChar);
                sorted += new string(toChar);                
            }
            return sorted;
        }
        static void Main(string[] args)
        {
            string str1 = "43512abc87241dDfe";
            string str2 = "43512abc87241fdeFsSf";
            string str3 = "aDAbc43512abc87241fdeFsSf";

            int n1 = str1.Length;
            int n2 = str2.Length;
            int n3 = str3.Length;

            Console.WriteLine(get_string(str1, n1));
            Console.WriteLine(get_string(str2, n2));
            Console.WriteLine(get_string(str3, n3));
        }
    }
}


