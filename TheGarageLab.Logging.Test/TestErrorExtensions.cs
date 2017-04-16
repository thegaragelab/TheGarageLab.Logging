using System;
using Xunit;
using Moq;

namespace TheGarageLab.Logging.Test
{
    /// <summary>
    /// Test extension methods emitting Debug level logs
    /// </summary>
    public class TestErrorExtensions : TestData
    {
        /// <summary>
        /// Constructor to set up test data
        /// </summary>
        public TestErrorExtensions() : base() { }

        [Fact]
        public void NullMessageWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Error((string)null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullMessageWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Error(TestMessage);
            mock.Verify(logger => logger.Write(Severity.Error, TestMessage, null), Times.Once());
        }

        [Fact]
        public void NullFormatWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Error((string)null, TestFormatArg0, TestFormatArg1); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullFormatWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Error(TestFormat, TestFormatArg0, TestFormatArg1);
            mock.Verify(logger => logger.Write(Severity.Error, TestFormatResult, null), Times.Once());
        }

        [Fact]
        public void NonNullFormatWithIncorrectArgumentsWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<FormatException>(() => { mock.Object.Error(TestFormat, TestFormatArg0); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NullCauseWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Error((Exception)null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Error(TestException);
            mock.Verify(logger => logger.Write(Severity.Error, TestException.GetType().Name, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNullMessageWithFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Error(TestException, null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWithNonNullMessageWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Error(TestException, TestMessage);
            mock.Verify(logger => logger.Write(Severity.Error, TestMessage, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNullFormatWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Error(TestException, null, TestFormatArg0, TestFormatArg1); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWithNonNullFormatWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Error(TestException, TestFormat, TestFormatArg0, TestFormatArg1);
            mock.Verify(logger => logger.Write(Severity.Error, TestFormatResult, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNonNullFormatWithIncorrectArgumentsWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<FormatException>(() => { mock.Object.Error(TestException, TestFormat, TestFormatArg0); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }
    }
}
