using System;
using TheGarageLab.Ensures;

namespace TheGarageLab.Logging
{
    /// <summary>
    /// Extension methods for working with ILogger
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Emit a log entry with Debug severity and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Debug(this ILogger logger, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Debug, message, null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Debug(this ILogger logger, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Debug, string.Format(format, args), null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a cause
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        public static void Debug(this ILogger logger, Exception cause)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            logger.Write(Severity.Debug, cause.GetType().Name, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="message"></param>
        public static void Debug(this ILogger logger, Exception cause, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Debug, message, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Debug(this ILogger logger, Exception cause, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Debug, string.Format(format, args), cause);
        }
    }
}
