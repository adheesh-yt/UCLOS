using System;
using System.Collections.Generic;
using Main_Commands;
using OSEEG;

namespace UCLOS.Command_Files
{
    public class Command_Manager
    {
        private List<UCLOSCMD> UCLOSCMD;

        public Command_Manager()
        {
            this.UCLOSCMD = new List<UCLOSCMD>(9);
            this.UCLOSCMD.Add(new Help("help"));
            this.UCLOSCMD.Add(new Ana("ana"));
            this.UCLOSCMD.Add(new Cat("kitty"));
            this.UCLOSCMD.Add(new Credits("credits"));
            this.UCLOSCMD.Add(new cnet("cnet"));
            this.UCLOSCMD.Add(new Clear("clear"));
            this.UCLOSCMD.Add(new reboot("reboot"));
            this.UCLOSCMD.Add(new Shutdown("ExitOS"));
        }

        public String procresUserInput(String Input)
        {
            String[] split = Input.Split(' ');
            String label = split[0];
            List<String> args = new List<String>();

            int ctr = 0;
            foreach (String s in split)
            {
                if (ctr != 0)
                    args.Add(s);

                ++ctr;
            }

            foreach (UCLOSCMD cmd in this.UCLOSCMD)
            {
                if (cmd.name == label)
                {
                    return cmd.execute(args.ToArray());
                }
            }
            return "";
        }
    }
}
