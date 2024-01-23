using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework.Internal;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    private FileLogger? fileLogger;
    private readonly string filePath = "text.txt";

    [TestInitialize]
    public void Constructor()
    {
<<<<<<< HEAD
        fileLogger = new FileLogger(filePath);
        fileLogger.FileName = filePath;
=======
        fileLogger = new FileLogger(_filePath);
>>>>>>> b62140cbcf3a45df6c418617ea6affa23f3abec4
    }

    [TestMethod]
    public void Log_FileCreated_Successful()
    {
        // Arrange
        var logger = new FileLogger(filePath)
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
        var logger = new FileLogger(filePath);
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("MM/dd/yyyy");

        // Act
        logger.Log(LogLevel.Information, "Test message");
        File.AppendAllText(logger.FilePath, formattedDate);
        //File.AppendAllText(logger.FilePath, );
        

        // Assert
<<<<<<< HEAD
        var logContent = File.ReadAllText(logger.FilePath);
        
=======
        var logContent = File.ReadAllText(_filePath);
>>>>>>> b62140cbcf3a45df6c418617ea6affa23f3abec4
        StringAssert.Equals(formattedDate, logContent);
        StringAssert.Equals("FileLogger", logContent);
        StringAssert.Equals(LogLevel.Information.ToString(), logContent);
        StringAssert.Equals("Test message", logContent);
    }


    [TestMethod]
    public void Log_OverwritesExistingLogFile_Successful()
    {
        // Arrange
        var logger = new FileLogger(filePath);

        // Act
        logger.Log(LogLevel.Information, "First message");
        logger.Log(LogLevel.Warning, "Second message");

        // Assert
        var logContent = File.ReadAllText(_filePath);
        Assert.AreNotEqual("First message", logContent);
    }



}

