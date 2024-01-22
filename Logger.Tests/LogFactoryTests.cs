using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckClassName_Success()
    {
        LogFactory logFactory = new LogFactory();
        BaseLogger? fileLogger = logFactory.CreateLogger("FileLogger");
        
        if(fileLogger != null)
            Assert.AreEqual("FileLogger", fileLogger.ClassName);
    }
}
