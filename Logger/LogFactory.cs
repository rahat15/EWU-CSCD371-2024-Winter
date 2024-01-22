namespace Logger;

public class LogFactory
{
    private string? filePath;

    public BaseLogger? CreateLogger(string className)
    {
        //ConfigureFileLogger(filePath);
        if(filePath == null) 
        {
            return null;
        }
        else
        {
            FileLogger logger = new FileLogger() { ClassName = className };

            return logger;
        }
    }

    public void ConfigureFileLogger(string filePath)
    {
        this.filePath = filePath;
    }
}
