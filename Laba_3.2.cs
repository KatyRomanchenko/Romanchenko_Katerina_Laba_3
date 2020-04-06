using System;
using System.Collections.Generic;

/*✔Дано словник. 
 *✔Видалити пробіли в значеннях його ключів*/
namespace Laba_3._2_0
{
    class Program
    {
        static void printDictionary(Dictionary<string, string> dictionary)
        {
            foreach (string c in dictionary.Keys)
            {
                Console.WriteLine("[" + c + "] =" + dictionary[c]);
            }
        }

        static string myTrim(string s, string c)
        {
            string str = s.Replace(c, "");
            return str;
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> smth = new Dictionary<string, string>(7);
            Dictionary<string, string> tmp = new Dictionary<string, string>(7);
            List<string> removals = new List<string>();

            smth.Add("1", "smth1");
            smth.Add("2", "smth2");
            smth.Add("9   6", "smth3");
            smth.Add(" 8  6", "smth4");
            smth.Add("5", "smth5");
            smth.Add("6", "smth6");
            smth.Add("7", "smth7");

            Console.WriteLine("before:");
            printDictionary(smth);
            
            foreach (string c in smth.Keys)
            {
                string NewC = myTrim(c, " ");
                tmp.Add(NewC, smth[c]);
                removals.Add(c);
            }

            foreach (string c in removals)
            {
            smth.Remove(c);
            }

            foreach (string c in tmp.Keys)
            {
                smth.Add(c, tmp[c]);
            }

            Console.WriteLine("after:");
            printDictionary(smth);

            Console.ReadKey();
        }
    }
}
