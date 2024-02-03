using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLOS.Command_Files
{
    public class UCLOSCMD
    {
        public readonly String name;
        public UCLOSCMD(String name) {  this.name = name; }

        public virtual String execute(String[] args) { return ""; }
    }
}
