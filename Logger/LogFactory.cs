using System;

namespace Logger;

public class LogFactory
{
    private string? _filePath;

    public void ConfigureFileLogger(string filePath)
    {
        FilePath = filePath;
    }

    public string FilePath
    {
        get => _filePath!; //telling compiler it's okay to be null in this case
        set
        {
            //if value is null throw exception
            _filePath = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public BaseLogger? CreateLogger(string className)
    {
        ConfigureFileLogger(FilePath);
        if (FilePath == null)
        {
            return null;
        }
        else
        {
            FileLogger logger = new(FilePath) { ClassName = className };

            return logger;
        }

    }


}
