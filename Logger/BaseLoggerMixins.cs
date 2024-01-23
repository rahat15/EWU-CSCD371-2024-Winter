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
        }
    }
    public static void Warning(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger == null)
        {
            throw new System.ArgumentNullException(nameof(logger));
        }
        else
        {
            logger.Log(LogLevel.Warning, string.Format(CultureInfo.CurrentCulture, message, args));
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
        }
    }

}
