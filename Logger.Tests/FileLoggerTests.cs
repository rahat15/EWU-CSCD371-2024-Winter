using System;
using System.Globalization;
using System.IO;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework.Internal;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    //private FileLogger? _fileLogger;
    private readonly string _filePath = "text.txt";


    [TestInitialize]
    public void Constructor()
    {
        //_fileLogger = new FileLogger(_filePath);
        string _directory = Directory.GetCurrentDirectory();
        string fileName = "test.txt";
        string filePath = Path.Combine(_directory, fileName);

        LogFactory logFactory = new();
        logFactory.ConfigureFileLogger(fileName);
        //FileLogger? logger = logFactory.CreateLogger(nameof(FileLogger));
    }

    [TestMethod]
    public void Log_FileCreated_Successful()
    {
        // Arrange
        var logger = new FileLogger(_filePath)
        {
            ClassName = "Test"
        };

        // Act
        logger.Log(LogLevel.Information, "Test Message");

        // Assert
        Assert.IsTrue(File.Exists(_filePath));

    }

    [TestMethod]
    public void Log_WriteLogToFile_Successful()
    {
        //// Arrange
        //var logger = new FileLogger(_filePath);
        //DateTime currentDate = DateTime.Now;
        //string formattedDate = currentDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

        //// Act
        //logger.Log(LogLevel.Information, "Test message");
        //File.AppendAllText(logger.FilePath, formattedDate);



        //// Assert

        //var logContent = File.ReadAllText(logger.FilePath);

        //StringAssert.Contains(logContent, formattedDate);
        //StringAssert.Equals("FileLogger", logContent);
        //StringAssert.Equals(LogLevel.Information.ToString(), logContent);
        //StringAssert.Equals("Test message", logContent);


        string fileName = "test.txt";
        // Arrange
        //string virtualPath = Path.Combine("C:\\Users\\Cynthia\\Desktop", fileName);
        //string virtualPath=System.Reflection.Assembly.GetExecutingAssembly().Location;
        //virtualPath = Path.Combine(virtualPath, fileName);

        string virtualPath = string.Join(@"\", (Environment.CurrentDirectory));
        string path = Path.Combine(virtualPath, fileName);
        FileLogger fileLogger = new(path);


        // Act
        fileLogger.Log(LogLevel.Warning, "Warnings");

        string log = $"{System.DateTime.Now} {"FileLogger"} {LogLevel.Warning}: {"Warnings"}";

        //string read="";
        string contents = File.ReadLines(path).Last();

        //if (File.Exists(virtualPath))
        //{
        //    // Create a file to write to.
        //    StreamReader sr = File.OpenText(virtualPath);;
        //    read = sr.ReadToEnd();
        //    read.Trim();
        //}

        // Assert
        Assert.AreEqual(log, contents);
    }



    [TestMethod]
    public void Log_OverwritesExistingLogFile_Successful()
    {
        // Arrange
        var logger = new FileLogger(_filePath);

        // Act
        logger.Log(LogLevel.Information, "First message");
        logger.Log(LogLevel.Warning, "Second message");

        // Assert
        var logContent = File.ReadAllText(_filePath);
        Assert.AreNotEqual("First message", logContent);
    }

}




