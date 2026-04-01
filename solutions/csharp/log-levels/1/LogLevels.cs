static class LogLine
{
    public static string Message(string logLine)
    {
         int index = logLine.IndexOf(':');
    string message = logLine.Substring(index + 1);
    return message.Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int firstIndex = logLine.IndexOf('[');
        int lastIndex = logLine.IndexOf(']');
    string level = logLine.Substring(firstIndex +1,lastIndex - firstIndex -1 );
    return level.ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
          int index = logLine.IndexOf(':');
    string message = logLine.Substring(index + 1).Trim();
        string level = logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - logLine.IndexOf('[') - 1).ToLower();

        string formattedMessage = $"{message} ({level})";

        return formattedMessage;
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
