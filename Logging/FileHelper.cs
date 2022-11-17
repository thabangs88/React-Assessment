using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public static class FileHelper
    {
        public static string FileName { get; set; }

        public static void WriteToFile(string text)
        {
            File.AppendAllLines(FileHelper.FileName, new[] { text });
        }
    }
}
