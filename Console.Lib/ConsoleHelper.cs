using System.Diagnostics;
using System.IO;

namespace Console.Lib
{
    /// <summary>
    /// Provides wrapper to Console
    /// </summary>
    public class ConsoleHelper
    {
        ProcessStartInfo PSI;
        string EndCommand = "exit";  // the command that we will use to exit the console process
        StreamReader ErrorStream;   // The Stream to read errors
        
        public ConsoleHelper()
        {
            PSI = new ProcessStartInfo("cmd");
            PSI.CreateNoWindow = true;
            PSI.ErrorDialog = false;
            PSI.LoadUserProfile = true;
            PSI.RedirectStandardInput = true;
            PSI.RedirectStandardOutput = true;
            PSI.RedirectStandardError = true;
            PSI.UseShellExecute = false;
            PSI.WindowStyle = ProcessWindowStyle.Hidden;
        }

        /// <summary>
        /// Gets the last error in the console, like a command not found
        /// </summary>
        public string LastError
        {
            get
            {
                string Error = string.Empty;
                if (ErrorStream != null)
                {
                    if (!ErrorStream.EndOfStream)
                    {
                        Error = ErrorStream.ReadToEnd();
                    }
                }
                if (string.IsNullOrEmpty(Error))
                {
                    Error = "No Errors!";
                }
                return Error;
            }
        }
        
        /// <summary>
        /// Execute set of commands passed to it
        /// </summary>
        /// <param name="commands">Commands separated by new-line</param>
        /// <returns>Results of commands execution</returns>
        public string ExecuteCommands(string commands)
        {
            Process proc = new Process();
            proc.StartInfo = PSI;
            proc.Start();
            StreamWriter sw = proc.StandardInput;
            StreamReader sr = proc.StandardOutput;
            ErrorStream = proc.StandardError;
            sw.WriteLine(commands);
            sw.WriteLine(EndCommand);
            string result = sr.ReadToEnd();
            return result;
        }
    }
}