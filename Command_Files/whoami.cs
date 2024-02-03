using System;
using sys = Cosmos.System;
using UCLOS;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class whoami : UCLOSCMD
    {

        public whoami(String name) : base(name) { }

        public override String execute(String[] args)
        {
            return $"You are {Kernel.username}";

        }

    }
}
