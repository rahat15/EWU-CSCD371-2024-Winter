namespace Logger;

public class LogFactory
{
    private string? filePath;

    public BaseLogger? CreateLogger(string className)
    {
        return null;
    }

    public void ConfigureFileLogger(string filePath)
    {
        this.filePath = filePath;
    }
}
