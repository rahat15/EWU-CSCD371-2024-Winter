using System.Globalization;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger == null)
        {
            throw new System.ArgumentNullException(nameof(logger));
        }
        else
        {
            logger.Log(LogLevel.Error, string.Format(CultureInfo.CurrentCulture, message, args));
            string formatting = string.Format(message, args);
            //logger.Log(LogLevel.Error, formatting);
        }

    }
    public static void Warning(this BaseLogger? logger, string message, params object[] args)
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

    public static void Debug(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger == null)
        {
            throw new System.ArgumentNullException(nameof(logger));
        }
        else
        {
            logger.Log(LogLevel.Debug, string.Format(CultureInfo.CurrentCulture, message, args));
            string formatting = string.Format(message, args);
            //logger.Log(LogLevel.Debug, formatting);
        }
    }

    public static void Information(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger == null)
        {
            throw new System.ArgumentNullException(nameof(logger));
        }
        else
        {
            logger.Log(LogLevel.Information, string.Format(CultureInfo.CurrentCulture, message, args));
            string formatting = string.Format(message, args);
            //logger.Log(LogLevel.Information, formatting);
        }
    }

}
