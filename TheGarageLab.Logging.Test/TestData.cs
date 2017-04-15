using System;

namespace TheGarageLab.Logging.Test
{
    /// <summary>
    /// Set up the test data in a single location
    /// </summary>
    public class TestData
    {
        /// <summary>
        /// Data to use for testing non-null messages
        /// </summary>
        public readonly string TestMessage = "My Message";

        /// <summary>
        /// Data to use for testing non-null exceptions
        /// </summary>
        public readonly Exception TestException = new Exception();

        /// <summary>
        /// Data to use for testing non-null format strings
        /// </summary>
        public readonly string TestFormat = "0 = {0}, 1 = {1}";

        /// <summary>
        /// Data for first format string argument
        /// </summary>
        public readonly string TestFormatArg0 = "arg0";

        /// <summary>
        /// Data for second format string argument
        /// </summary>
        public readonly string TestFormatArg1 = "arg1";

        /// <summary>
        /// The resulting formatted string
        /// </summary>
        public readonly string TestFormatResult;

        /// <summary>
        /// Constructor to set up the test data
        /// </summary>
        protected TestData()
        {
            TestFormatResult = string.Format(TestFormat, TestFormatArg0, TestFormatArg1);
        }
    }
}
