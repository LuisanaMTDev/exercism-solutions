static class LogLine
{
    public static string Message(string logLine)
    {
      string[] logAndMessage = logLine.Split(": ");
      return logAndMessage[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
      string trimedLogLine = logLine.Trim();
      string[] logAndMessage = trimedLogLine.Split(": ");

      switch (logAndMessage[0].Trim())
      {
        case "[INFO]": 
          return "info";

        case "[WARNING]":
          return "warning";

        case "[ERROR]":
            return "error";

        default: return "Unknow log level";
      }
    }

    public static string Reformat(string logLine)
    {
      string trimedLogLine = logLine.Trim();
      string[] logAndMessage = trimedLogLine.Split(": ");

      switch (logAndMessage[0].Trim())
      {
        case "[INFO]": 
          return $"{logAndMessage[1].Trim()} (info)";

        case "[WARNING]":
          return $"{logAndMessage[1].Trim()} (warning)";

        case "[ERROR]":
            return $"{logAndMessage[1].Trim()} (error)";

        default: return "Unknow log level";
      }
    }
}
