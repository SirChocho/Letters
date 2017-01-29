using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letters
{
    class letters
    {
        static void Main(string[] args)
        {
            var start = char.Parse(Console.ReadLine());
            var end = char.Parse(Console.ReadLine());
            var whitoutThisLetter = char.Parse(Console.ReadLine());

            var counter = 0;

            for (char i = 'a'; i <= start; i++)
            {
                for (char j = 'a'; j <= end; j++)
                {
                    Console.Write("{0}{1}{2} ", start,end,i);
                    counter ++;
                }
            }
        }
    }
}
