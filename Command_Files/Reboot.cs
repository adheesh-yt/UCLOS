using System;
using Sys = Cosmos.System;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class reboot : UCLOSCMD
    {

        public reboot (String name) : base(name) { }

        public override String execute(String[] args)
        {
            Sys.Power.Reboot();
            return "";

        }

    }
}
