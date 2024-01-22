using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public FileLogger() { }

        public override void Log(LogLevel logLevel, string message)
        {
            throw new NotImplementedException();
        }
    }
}
