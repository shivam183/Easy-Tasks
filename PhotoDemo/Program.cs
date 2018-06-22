using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MattedPhoto mp = new MattedPhoto(25, 30, "Blue");
            FramedPhoto fp = new FramedPhoto(25, 30, "Silver", "Modern");

           
            Console.WriteLine(mp);
            Console.WriteLine(fp);
        }
    }
}
