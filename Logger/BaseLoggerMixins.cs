namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? logger, string message, params object[] args)
    {
        if(logger ==  null) 
        {
            throw new System.ArgumentNullException(nameof(logger));
        }
        else
        {
            logger.Log(LogLevel.Error, string.Format(message, args));
        }
    }

<<<<<<< Updated upstream
=======
    public static void Warning(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger == null)
        {
            throw new System.ArgumentNullException(nameof(logger));
        }
        else
        {
            logger.Log(LogLevel.Error, string.Format(message, args));
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
            logger.Log(LogLevel.Error, string.Format(message, args));
        }
    }
>>>>>>> Stashed changes

}
