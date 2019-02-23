using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logging
{
   public class Logging : ILogging
    {
        public static void WriteToFile(List<Object> logItems)
        {
            foreach (var item in logItems)
            {

            }
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
