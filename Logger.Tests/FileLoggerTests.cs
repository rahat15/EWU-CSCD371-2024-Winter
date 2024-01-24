using System;
using System.Globalization;
using System.IO;

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
        // Arrange
        var logger = new FileLogger(_filePath);
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

        // Act
        logger.Log(LogLevel.Information, "Test message");
        File.AppendAllText(logger.FilePath, formattedDate);
        
        

        // Assert
        var logContent = File.ReadAllText(_filePath);

        StringAssert.Contains(logContent, formattedDate);
        StringAssert.Equals("FileLogger", logContent);
        StringAssert.Equals(LogLevel.Information.ToString(), logContent);
        StringAssert.Equals("Test message", logContent);
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

