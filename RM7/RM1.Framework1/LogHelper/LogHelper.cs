using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace RM7.Framework.LogHelper
{
    public class LogHelper
    {
        static LogHelper()
        {
            if (!Directory.Exists(StaticConstant.LogPath))
            {
                Directory.CreateDirectory(StaticConstant.LogPath);
            }
        }

        public static void LogConsole(string msg, ConsoleColor color)
        {
            Log(msg);
            lock (LogLock)
            {
                foreach (var item in msg.ToCharArray())
                {
                    Thread.Sleep(50);
                    Console.ForegroundColor = color;
                    Console.Write($"{item}");
                }
                Console.WriteLine("");
            }
        }

        private static readonly object LogLock = new object();

        public static void Log(string msg)
        {
            try
            {
                string fileName = "log.txt";
                string totalPath = Path.Combine(StaticConstant.LogPath, fileName);
                //if (!Directory.Exists(StaticConstant.LogPath))
                //{
                //    Directory.CreateDirectory(StaticConstant.LogPath);
                //}
                lock (LogLock)
                {
                    using (StreamWriter sw = File.AppendText(totalPath))
                    {
                        sw.WriteLine(string.Format("{0}:{1}", DateTime.Now, msg));
                        sw.WriteLine("***************************************************");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
