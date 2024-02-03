using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLOS.Command_Files;

namespace OSEEG
{
    public class Cat : UCLOSCMD
    {

        public Cat(string name) : base(name) { }

        public override string execute(string[] args)
        {
            Console.WriteLine(@"
             ............
              /\_/\  
             ( owo ) - mow
              (   ""  )
               -_-_-_-   
");
            return "";

        }

    }
}
