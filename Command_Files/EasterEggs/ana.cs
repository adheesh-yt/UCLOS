using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLOS.Command_Files;

namespace OSEEG
{
    public class Ana : UCLOSCMD
    {

        public Ana(string name) : base(name) { }

        public override string execute(string[] args)
        {
            Console.WriteLine(@"
             O  O
            /|/\|/
            / \/ \
");
            Console.WriteLine("The People Who Made this - Adheesh and Aadvik");
            return "";

        }

    }
}
