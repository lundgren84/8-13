using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
   public interface ILogger
    {
        List<string> LoggPosts { get; set; }

        void Logg(string message);
    }
}
