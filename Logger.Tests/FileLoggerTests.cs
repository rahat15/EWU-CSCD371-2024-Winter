using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

#nullable enable

[TestClass]
public class FileLoggerTests
{
    private FileLogger? fileLogger;
    private readonly string filePath = "text.txt";

    [TestInitialize]
    public void Constructor()
    {
        fileLogger = new FileLogger();
        fileLogger.FileName = filePath;
    }

    [TestMethod]
    public void FileLogger_FilePathCheck_Success()
    {
        Assert.AreEqual(filePath, fileLogger!.FileName);
    }

    [TestMethod]
    public void FileLogger_FilePathCheck_Fail()
    {
        Assert.AreNotEqual("wringText.txt", fileLogger!.FileName);
    }


    //[TestMethod]
    //public void Log_WriteToAFile_Success()
    //{
    //    // Arrange
    //    string filePath = "C:\\Users\\Sanmeet\\OneDrive\\Desktop\\Parteek Applicaton\\rahat\\Winter 24\\.Net (CSCD471)\\EWU-CSCD371-2024-Winter\\test.txt";
    //    string message = "Hey we passed";

    //    // Ensure the file does not exist before the test
    //    if (File.Exists(filePath))
    //    {
    //        File.Delete(filePath);
    //    }

    //    // Create a FileLogger instance
    //    FileLogger fileLogger = new FileLogger()
    //    {
    //        ClassName = "FileLogger"

    //    };

    //    // Act
    //    fileLogger.Log(LogLevel.Error, message);

    //    // Assert
    //    // Read the log entry from the file
    //    string[] lines = File.ReadAllLines(filePath);

    //    // Ensure there is only one line in the file
    //    Assert.AreEqual(1, lines.Length);

    //    // Format the expected log entry
    //    DateTime dateTime = DateTime.Now;
    //    string expectedLogEntry = $"{dateTime} FileLogger Error: {message}";

    //    // Compare the actual log entry with the expected log entry
    //    Assert.AreEqual(expectedLogEntry, lines[0]);
    //}

}
