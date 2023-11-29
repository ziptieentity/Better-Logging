namespace Logging
{
    /// <summary>
    /// A static class which contains better methods for logging messages to the console.
    /// </summary>
    public static class Logger
    {
        #region Constants
        // Log
        public const ConsoleColor LOG_TEXT_COLOR = ConsoleColor.Green;
        public const ConsoleColor LOG_BACKGROUND_COLOR = ConsoleColor.Black;
        public const string LOG_PREFIX = "[LOG]: {0}";

        // Warning
        public const ConsoleColor WARNING_TEXT_COLOR = ConsoleColor.Yellow;
        public const ConsoleColor WARNING_BACKGROUND_COLOR = ConsoleColor.Black;
        public const string WARNING_PREFIX = "[WARNING]: {0}";

        // Error
        public const ConsoleColor ERROR_TEXT_COLOR = ConsoleColor.Red;
        public const ConsoleColor ERROR_BACKGROUND_COLOR = ConsoleColor.Black;
        public const string ERROR_PREFIX = "[ERROR]: {0}";

        // Exception
        public const ConsoleColor EXCEPTION_TEXT_COLOR = ConsoleColor.DarkRed;
        public const ConsoleColor EXCEPTION_BACKGROUND_COLOR = ConsoleColor.Red;
        public const string EXCEPTION_PREFIX = "[EXCEPTION]: {0}";
        #endregion

        #region Log Color
        /// <summary>
        /// Logs a message to the console with the specified text and background color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="textColor">The color of the text.</param>
        /// <param name="backgroundColor">The color of the background.</param>
        public static void LogColor(object message, ConsoleColor textColor, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message.ToString());

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        /// <summary>
        /// Logs a formatted message to the console with the specified text and background color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="textColor">The color of the text.</param>
        /// <param name="backgroundColor">The color of the background.</param>
        /// <param name="format">The format of the message.</param>
        public static void LogColor(string message, ConsoleColor textColor, ConsoleColor backgroundColor, params object[] format)
        {
            LogColor((object)string.Format(message, format), textColor, backgroundColor);
        }
        #endregion

        #region Log
        /// <summary>
        /// Logs a green log message to the console.
        /// <para>
        /// You can log a formatted message using the following method: <seealso cref="Log(string, object[])"/>
        /// </para>
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void Log(object message)
        {
            LogColor(LOG_PREFIX, LOG_TEXT_COLOR, LOG_BACKGROUND_COLOR, message);
        }
        /// <summary>
        /// Logs a formatted green log message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="format">The format of the message.</param>
        public static void Log(string message, params object[] format)
        {
            LogColor(LOG_PREFIX, LOG_TEXT_COLOR, LOG_BACKGROUND_COLOR, string.Format(message, format));
        }
        #endregion

        #region Log Warning
        /// <summary>
        /// Logs a yellow warning message to the console.
        /// <para>
        /// You can log a formatted message using the following method: <seealso cref="LogWarning(string, object[])"/>
        /// </para>
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogWarning(object message)
        {
            LogColor(WARNING_PREFIX, WARNING_TEXT_COLOR, WARNING_BACKGROUND_COLOR, message);
        }
        /// <summary>
        /// Logs a yellow warning message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="format">The format of the message.</param>
        public static void LogWarning(string message, params object[] format)
        {
            LogColor(WARNING_PREFIX, WARNING_TEXT_COLOR, WARNING_BACKGROUND_COLOR, string.Format(message, format));
        }
        #endregion

        #region Log Error
        /// <summary>
        /// Logs a red error message to the console.
        /// <para>
        /// You can log a formatted message using the following method: <seealso cref="LogError(string, object[])"/>
        /// </para>
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogError(object message)
        {
            LogColor(ERROR_PREFIX, ERROR_TEXT_COLOR, ERROR_BACKGROUND_COLOR, message);
        }
        /// <summary>
        /// Logs a red error message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="format">The format of the message.</param>
        public static void LogError(string message, params object[] format)
        {
            LogColor(ERROR_PREFIX, ERROR_TEXT_COLOR, ERROR_BACKGROUND_COLOR, string.Format(message, format));
        }
        #endregion

        #region Log Exception
        /// <summary>
        /// Logs an exception to the console.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        public static void LogException(Exception exception)
        {
            LogColor(EXCEPTION_PREFIX, EXCEPTION_TEXT_COLOR, EXCEPTION_BACKGROUND_COLOR, string.Format("{0}\n{1}", exception.Message, exception.StackTrace));
        }
        #endregion
    }
}