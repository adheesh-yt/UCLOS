using System;
using sys = Cosmos.System;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class Shutdown : UCLOSCMD
    {

        public Shutdown(String name) : base(name) { }

        public override String execute(String[] args)
        {
            sys.Power.Shutdown();
            return "";

        }

    }
}
