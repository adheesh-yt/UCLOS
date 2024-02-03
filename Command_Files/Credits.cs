using System;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class Credits : UCLOSCMD
    {

        public Credits(string name) : base(name) { }

        public override string execute(string[] args)
        {
            Console.WriteLine(@"
@copyright (C) Hearwin Corpration
All Rights Reserved.
");
            return "";

        }

    }
}
