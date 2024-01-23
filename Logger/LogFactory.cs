namespace Logger;

public class LogFactory
{
    private string? _filePath;

    public BaseLogger? CreateLogger(string className)
    {
        ConfigureFileLogger(_filePath!);
        if (_filePath == null)
        {
            return null;
        }
        else
        {
            FileLogger logger = new(_filePath) { ClassName = className };

            return logger;
        }

    }

    public void ConfigureFileLogger(string filePath)
    {
        _filePath = filePath;
    }
}
