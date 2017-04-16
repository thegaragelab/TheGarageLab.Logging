using System;
using Xunit;
using Moq;

namespace TheGarageLab.Logging.Test
{
    /// <summary>
    /// Test extension methods emitting Debug level logs
    /// </summary>
    public class TestWarnExtensions : TestData
    {
        [Fact]
        public void NullMessageWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Warn((string)null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullMessageWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Warn(TestMessage);
            mock.Verify(logger => logger.Write(Severity.Warning, TestMessage, null), Times.Once());
        }

        [Fact]
        public void NullFormatWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Warn((string)null, TestFormatArg0, TestFormatArg1); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullFormatWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Warn(TestFormat, TestFormatArg0, TestFormatArg1);
            mock.Verify(logger => logger.Write(Severity.Warning, TestFormatResult, null), Times.Once());
        }

        [Fact]
        public void NonNullFormatWithIncorrectArgumentsWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<FormatException>(() => { mock.Object.Warn(TestFormat, TestFormatArg0); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NullCauseWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Warn((Exception)null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Warn(TestException);
            mock.Verify(logger => logger.Write(Severity.Warning, TestException.GetType().Name, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNullMessageWithFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Warn(TestException, null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWithNonNullMessageWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Warn(TestException, TestMessage);
            mock.Verify(logger => logger.Write(Severity.Warning, TestMessage, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNullFormatWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Warn(TestException, null, TestFormatArg0, TestFormatArg1); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWithNonNullFormatWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Warn(TestException, TestFormat, TestFormatArg0, TestFormatArg1);
            mock.Verify(logger => logger.Write(Severity.Warning, TestFormatResult, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNonNullFormatWithIncorrectArgumentsWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<FormatException>(() => { mock.Object.Warn(TestException, TestFormat, TestFormatArg0); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }
    }
}
