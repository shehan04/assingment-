using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            List<string> list = new List<string>(new string[] { "Java", "C#", "C++" ,"PHP"});
            char character = 'C';
            List<string> Value = p.Sort(list, character);
            for (int j = 0; j < Value.Count; j++)
            {
                Console.WriteLine(Value[j]);
               
            }
            Console.ReadLine();

           
        }
        public List<string> Sort(List<string> theList, char theChar)
        {
            List<string> soretedList = new List<string>();
            soretedList = theList.FindAll(a => a.Substring(0, 1) == theChar.ToString());
            return soretedList;
        }

    }
}
