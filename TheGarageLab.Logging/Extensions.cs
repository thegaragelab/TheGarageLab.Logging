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

        /// <summary>
        /// Emit a log entry with Debug severity and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Info(this ILogger logger, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Information, message, null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Info(this ILogger logger, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Information, string.Format(format, args), null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a cause
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        public static void Info(this ILogger logger, Exception cause)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            logger.Write(Severity.Information, cause.GetType().Name, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="message"></param>
        public static void Info(this ILogger logger, Exception cause, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Information, message, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Info(this ILogger logger, Exception cause, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Information, string.Format(format, args), cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Warn(this ILogger logger, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Warning, message, null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Warn(this ILogger logger, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Warning, string.Format(format, args), null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a cause
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        public static void Warn(this ILogger logger, Exception cause)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            logger.Write(Severity.Warning, cause.GetType().Name, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="message"></param>
        public static void Warn(this ILogger logger, Exception cause, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Warning, message, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Warn(this ILogger logger, Exception cause, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Warning, string.Format(format, args), cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Error(this ILogger logger, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Error, message, null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Error(this ILogger logger, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Error, string.Format(format, args), null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a cause
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        public static void Error(this ILogger logger, Exception cause)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            logger.Write(Severity.Error, cause.GetType().Name, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="message"></param>
        public static void Error(this ILogger logger, Exception cause, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Error, message, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Error(this ILogger logger, Exception cause, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Error, string.Format(format, args), cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Fatal(this ILogger logger, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Fatal, message, null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Fatal(this ILogger logger, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Fatal, string.Format(format, args), null);
        }

        /// <summary>
        /// Emit a log entry with Debug severity and a cause
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        public static void Fatal(this ILogger logger, Exception cause)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            logger.Write(Severity.Fatal, cause.GetType().Name, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="message"></param>
        public static void Fatal(this ILogger logger, Exception cause, string message)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(message);
            logger.Write(Severity.Fatal, message, cause);
        }

        /// <summary>
        /// Emit a log entry with Debug severity, a cause and a formatted message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cause"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Fatal(this ILogger logger, Exception cause, string format, params object[] args)
        {
            Ensure.IsNotNull<ArgumentNullException>(cause);
            Ensure.IsNotNull<ArgumentNullException>(format);
            logger.Write(Severity.Fatal, string.Format(format, args), cause);
        }
    }
}
