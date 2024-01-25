using System.Globalization;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Error, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Error mixin got null");
        }

    }
    public static void Warning(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Warning, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Warning mixin got null");
        }
        
    }

    public static void Debug(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Debug, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Debug mixin got null");
        } 
   
    }

    public static void Information(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Information, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Information mixin got null");
        }
    }

}
