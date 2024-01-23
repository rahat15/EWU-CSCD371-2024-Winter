using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework.Internal;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    private FileLogger? fileLogger;
    private readonly string _filePath = "text.txt";

    [TestInitialize]
    public void Constructor()
    {
        fileLogger = new FileLogger(_filePath);
        fileLogger.FileName = _filePath;
    }

    [TestMethod]
    public void Log_WriteLogToFile_Successful()
    {
        // Arrange
        var logger = new FileLogger(_filePath)
        {
            ClassName = "Test"
    };

        // Act
        logger.Log(LogLevel.Information, "Test Message");

        // Assert
        Assert.IsTrue(File.Exists(logger.FilePath));
    }

}

