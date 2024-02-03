using System;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class Help : UCLOSCMD
    {

        public Help(string name) : base(name) { }

        public override string execute(string[] args)
        {
            Console.WriteLine("There are easter eggs not listed, check the website for them!");
            Console.WriteLine("help - Shows Commands");
            Console.WriteLine("credits - Shows Credits");
            Console.WriteLine("cnet [create/remove/credir/rmdir] <file.exe> - creates or removes a file");
            Console.WriteLine("cnet [edit/read] - edits or reads a file");
            Console.WriteLine("reboot - Restart");
            Console.WriteLine("ExitOS - Shutdown Oprating System");
            Console.WriteLine("clear - CLears Screen");
            Console.WriteLine("(Theese commands are case sensitive so please follow the case given)");
            return "";

        }

    }
}
