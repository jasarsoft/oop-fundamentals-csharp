﻿using System;
using System.Collections.Generic;

namespace Acme.Common
{
    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
