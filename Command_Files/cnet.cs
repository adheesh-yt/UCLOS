using System;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
using UCLOS.Command_Files;

namespace Main_Commands
{
    public class cnet : UCLOSCMD
    {
        public cnet(string name) : base(name) { }
        public override string execute(string[] args)
        {
            //file create/remove /Data/(Any File name).(extension)

            string response = "";

            switch (args[0])
            {
                //create
                case "create":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                        response = "Your File " + args[1] + " was created succesfully!";
                    }
                    catch (Exception ex)
                    {
                        Console.Beep();
                        response = "$System.File Expectation {0x000E2} File Not Created Due To It already Existing or Failure in Creation, please try after restart and delete the file {Expectation_System_Failure_File)";
                        Console.WriteLine(ex.Message, " For Better Clarification.");
                    }

                    break;

                case "remove":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                        response = "Your File " + args[1] + " was erased from existance succesfully!";
                    }
                    catch (Exception ex)
                    {
                        Console.Beep();
                        response = "$System.File Expectation {0x000D2} File Not Created Due To It not existing or Failure in Deletion, please try after restart and delete the file {Expectation_System_Failure_Romoval)";
                        Console.WriteLine(ex.Message, " For Better Clarification.");
                    }

                    break;
                case "credir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                        response = "Your Folder" + args[1] + "was created sucessfully!";
                    }
                    catch (Exception ex)
                    {
                        Console.Beep();
                        response = "$System.File Expectation {0x000E3} Folder Not Created Due To It already existing or Failure in Creation, please try after restart and delete the file {Expectation_System_Failure_Folder)";
                        Console.WriteLine(ex.Message, " For Better Clarification.");

                    }

                    break;
                case "rmdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1], true);
                        response = "Your Folder" + args[1] + "was removed sucessfully!";
                    }
                    catch (Exception ex)
                    {
                        Console.Beep();
                        response = "$System.File Expectation {0x000D3} File Not Created Due To It not existing or Failure in Deletion, please try after restart and delete the file {Expectation_System_Failure_Folder)";
                        Console.WriteLine(ex.Message, " For Better Clarification.");

                    }
                    break;
                case "edit":
                    //cnet edit 0:\MyFile.exe ECHO HI
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();
                        if (fs.CanWrite)
                        {
                            int ctr = 0;
                            StringBuilder win = new StringBuilder();
                            foreach (string s in args)
                            {
                                if (ctr > 1)
                                    win.Append(s + ' ');



                                ++ctr;
                            }
                            string txt = win.ToString();
                            byte[] data = Encoding.ASCII.GetBytes(txt.Substring(0, txt.Length - 1));

                            fs.Write(data, 0, data.Length);
                            fs.Close();
                            break;
                        }
                        else
                        {
                            response = "The system Did not feel like doing that(0xT010E), do not use unsupported characthers or make sure it is not read only. (Tired_System_No_Schools_PLS)";
                            break;
                        }

                    }
                    catch (Exception ex)
                    {
                        response = "Who Knows (0x0000) (Not-Identified Error) Or check source code.";
                        Console.WriteLine(ex.Message, " For Better Clarification.");
                    }
                    break;

                case "read":
                    FileStream fsa = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();
                    try
                    {
                        if (fsa.CanRead)
                        {
                            byte[] data = new byte[256];

                            fsa.Read(data, 0, data.Length);
                            response = Encoding.ASCII.GetString(data);
                            break;
                        }
                        else
                        {
                            response = "The system Did not feel like doing that(0xR020F), do not use unsupported characthers or make sure it exists. (I_Dont_Wanna_Read)";
                        }
                        break;
                    }
                    catch
                    {
                        response = "The system Did not feel like doing that(0xR020F), does the file exist or did you modify source?. (I_CANT_READ_CHINESE)";
                    }
                    break;

                case "windjka":
                    Console.Beep();
                    response = "WOWWWW YOU ACTUALLY TRIED THIS! CONGRATS!";

                    break;

                //what it will do if you type cnet gscdkuhvcga,ysdjtfa myfile.txt
                default:
                    response = "BRUH HOW DO YOU EXPECT ME TO DO THAT IF IT DOES NOT EXIST {Angry_Argument} {0x0010E}";
                    break;

            }
            return response;

        }
    }
}
