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
        
        string fileName = "test.txt";
        // Arrange
        

        string virtualPath = string.Join(@"\", (Environment.CurrentDirectory));
        string path = Path.Combine(virtualPath, fileName);
        FileLogger fileLogger = new(path);


        // Act
        fileLogger.Log(LogLevel.Warning, "Warnings");

        DateTime currentTime = DateTime.Now;
        string formattedDate = currentTime.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);


        string log = $"{formattedDate} {"FileLogger"} {LogLevel.Warning}: {"Warnings"}";

        //string read="";
        string contents = File.ReadLines(path).Last();

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




