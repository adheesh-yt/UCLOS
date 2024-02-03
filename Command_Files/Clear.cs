using System;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class Clear : UCLOSCMD
    {

        public Clear(String name) : base(name) { }

        public override String execute(String[] args)
        {
            Console.Clear();
            return "";

        }

    }
}
