using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
   public class DateTimeLogger : ILogger
    {
        public List<string> LoggPosts { get; set; }
       public DateTimeLogger()
        {
            this.LoggPosts = new List<string>();
        }
        public void Logg(string message)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            string time = datetime.ToString();
            LoggPosts.Add(message+"\n"+time);
        }
    }
}
