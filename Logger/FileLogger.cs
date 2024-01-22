using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public string FileName
        {
            get;
            set;
        }

        public string CurrentDirectory
        {
            get;
            set;
        }

        public string FilePath
        {
            get;
            set;
        }
        public FileLogger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;

        }

        public override void Log(LogLevel logLevel, string message)
        {
            using (System.IO.StreamWriter writeTo = System.IO.File.AppendText(this.FilePath))
            {
                writeTo.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                writeTo.WriteLine("name of class");
                writeTo.WriteLine("{0}", logLevel);
                writeTo.WriteLine("{0}", message);
                

            }
        }
    }
}
