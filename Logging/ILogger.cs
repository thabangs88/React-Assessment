using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public interface ILogger
    {
        void Debug(string logMessage);
        void Info(string logMessage);
        void Error(string logMessage);
    }
}
