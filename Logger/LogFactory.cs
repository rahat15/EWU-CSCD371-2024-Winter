namespace Logger;

public class LogFactory
{
    string? filePath;

    public BaseLogger? CreateLogger(string className)
    {

        return null;
    }

    public void ConfigureFileLogger(string filePath)
    {
        this.filePath = filePath;
    }
}
