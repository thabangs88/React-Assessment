using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logging;


namespace TestLogging
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //1. First create an empty text file.
            //2. Locate the file when running the application

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
    
                Logger logger = new Logger(openFileDialog1.FileName, EnumLogLevel.Info);

                logger.Debug("Debug Message Test");
                logger.Info("Info Message Test");
                logger.Error("Error Message Test");

                logger.Info("Demo of Logger Starting");

                for (int i = 0; i < 5; i++)
                {
                    logger.Info($"i = {i}");
                }

                logger.Info("Demo of Logger Complete");

                logger.Info("Logger Destroyed");

            }

            Console.WriteLine("Demo of Logger Complete");
            Console.ReadLine();
        }
    }
}
