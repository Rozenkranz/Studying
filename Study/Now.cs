using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Now : Future
    {
        public override void LuckyChance(int Day)
        {
            if (Day == 12)
                Console.WriteLine("WOW YOU ARE SO LUCKY");
        }
    }
}