using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckClassName_Success()
    {

        var logFactory = new LogFactory();
        string filePath = "C:\\path\\to\\your\\log.txt"; 
        logFactory.ConfigureFileLogger(filePath);

        var fileLogger = logFactory.CreateLogger("FileLogger");

        Assert.IsNotNull(fileLogger, "FileLogger should not be null");
        Assert.AreEqual("FileLogger", fileLogger?.ClassName);
    }
}
