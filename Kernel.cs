using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using UCLOS.Command_Files;
namespace UCLOS
{
    public class Kernel : Sys.Kernel
    {
        public static string command;
        private CosmosVFS AUFS;
        private Command_Manager ULCOSCMDMGR;
        public static string username;
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.AUFS);
            this.ULCOSCMDMGR = new Command_Manager();
            Console.WriteLine("@copyright (C) Heartwin Corp");
            Console.WriteLine("All Rights Reserved.");
            Console.WriteLine();
            Console.WriteLine("What's your name?: ");
            username = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine($"Welcome TO UCLOS {username}!");
        }

        protected override void Run()
        {
            String response;
            Console.Write($"@{username}>");
            String input = Console.ReadLine();
            response = this.ULCOSCMDMGR.procresUserInput(input);
            Console.WriteLine(response);
        }
    }

}
