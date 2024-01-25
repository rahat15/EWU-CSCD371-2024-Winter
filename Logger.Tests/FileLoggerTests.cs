using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework.Internal;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    private FileLogger? _fileLogger;
    private readonly string _filePath = "text.txt";

    [TestInitialize]
    public void Constructor()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        fileLogger = new FileLogger(filePath);
        fileLogger.FileName = filePath;
=======
        fileLogger = new FileLogger(_filePath);
>>>>>>> b62140cbcf3a45df6c418617ea6affa23f3abec4
=======
        _fileLogger = new FileLogger(_filePath);
>>>>>>> 7c47cc86540d67396dea65d617ccb19081ef18b0
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
        string formattedDate = currentDate.ToString("MM/dd/yyyy");

        // Act
        logger.Log(LogLevel.Information, "Test message");
        File.AppendAllText(logger.FilePath, formattedDate);
        
        

        // Assert
<<<<<<< HEAD
<<<<<<< HEAD
        var logContent = File.ReadAllText(logger.FilePath);
        
=======
        var logContent = File.ReadAllText(_filePath);
>>>>>>> b62140cbcf3a45df6c418617ea6affa23f3abec4
=======
        var logContent = File.ReadAllText(_filePath);
>>>>>>> 7c47cc86540d67396dea65d617ccb19081ef18b0
        StringAssert.Equals(formattedDate, logContent);
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

