﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new DateTimeLogger();
            var application = new LogApplication(logger);
            while (true)
            {
                Console.Clear();
                application.Run();
            }
        }
    }
}
