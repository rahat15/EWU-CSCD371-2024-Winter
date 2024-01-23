using System;
using System.Globalization;
using System.IO;


namespace Logger
{
    public class FileLogger : BaseLogger
    {
   

        private string FilePath
        {
            get;
            set;
        }
        public FileLogger(string filePath)
        {

            this.FilePath = filePath;

        }
        
       

        public override void Log(LogLevel logLevel, string message)
        {
            string currentDateTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.CurrentCulture);

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            using StreamWriter writeTo = File.AppendText(this.FilePath);
            writeTo.WriteLine("{0}", currentDateTime);
            writeTo.WriteLine("{0}", nameof(FileLogger));
            writeTo.WriteLine("{0}: ", logLevel);
            writeTo.WriteLine("{0}", message);

        }
    }
}
