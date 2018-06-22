using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner c = new Corner();
            Leaf l = new Leaf();
            Page p = new Page();
            Pancake pn = new Pancake();

            ITurnable[] turnables = new ITurnable[] { c, l, p, pn };
            


            foreach (ITurnable items in turnables)
            {
                TurnForAll(items);
            }


        }

        public static void TurnForAll(ITurnable turns)
        {
            turns.Turn();
        }
    }
}
