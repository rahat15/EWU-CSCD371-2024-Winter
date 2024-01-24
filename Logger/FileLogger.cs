﻿using System;
using System.Globalization;
using System.IO;


namespace Logger;

    public class FileLogger : BaseLogger
    {
   

        public string FilePath
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
            writeTo.WriteLine($"{currentDateTime} {nameof(FileLogger)} {logLevel}: {message}");
         
        }
    }

