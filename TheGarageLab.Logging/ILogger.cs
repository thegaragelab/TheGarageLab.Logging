using System;

namespace TheGarageLab.Logging
{
    /// <summary>
    /// The severity level for a single log entry
    /// </summary>
    public enum Severity
    {
        Debug,
        Information,
        Warning,
        Error,
        Fatal
    }

    /// <summary>
    /// The simplest abstraction of logging functionality
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Write a single log entry
        /// </summary>
        /// <param name="entry"></param>
        void Write(Severity severity, string message, Exception cause = null);
    }
}
