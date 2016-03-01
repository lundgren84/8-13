using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
   public class LogApplication
    {
        public ILogger InterFaceLogger;
       public LogApplication(ILogger InterFaceLogger)
        {
            this.InterFaceLogger = InterFaceLogger;              
        }
        public void Run()
        {
            Console.WriteLine("1) Add message to log \n2) Print log\n\nChoice");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            switch(key.KeyChar)
            {
                case '1':
                    Console.WriteLine("Write your message: ");
                    string msg = Console.ReadLine();
                    InterFaceLogger.Logg(msg);
                    break;
                case '2':
                    foreach (var item in InterFaceLogger.LoggPosts)
                    {
                        Console.WriteLine(item+"\n--------------------------\n");
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
