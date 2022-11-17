

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Logger: ILogger
    {
        private EnumLogLevel _enumLogLevel;

        public Logger(string fileName, EnumLogLevel enumLevel)
        {
            FileHelper.FileName = fileName;
            _enumLogLevel = enumLevel;

            FileHelper.WriteToFile($"{DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")} Logger Initialized");

        }

        public void Debug(string logMessage)
        {
            if(_enumLogLevel == EnumLogLevel.Debug || _enumLogLevel == EnumLogLevel.Error)
              FileHelper.WriteToFile($"{DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")} Debug {logMessage}");
        }

        public void  Error(string logMessage)
        {
                FileHelper.WriteToFile($"{DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")} ERR {logMessage}");
        }

        public void  Info(string logMessage)
        {
            if (_enumLogLevel == EnumLogLevel.Info)
               FileHelper.WriteToFile($"{DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")} INF {logMessage}");
        }

      
    }
}
