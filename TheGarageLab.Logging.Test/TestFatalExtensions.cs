using System;
using Xunit;
using Moq;

namespace TheGarageLab.Logging.Test
{
    /// <summary>
    /// Test extension methods emitting Debug level logs
    /// </summary>
    public class TestFatalExtensions : TestData
    {
        [Fact]
        public void NullMessageWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Fatal((string)null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullMessageWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Fatal(TestMessage);
            mock.Verify(logger => logger.Write(Severity.Fatal, TestMessage, null), Times.Once());
        }

        [Fact]
        public void NullFormatWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Fatal((string)null, TestFormatArg0, TestFormatArg1); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullFormatWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Fatal(TestFormat, TestFormatArg0, TestFormatArg1);
            mock.Verify(logger => logger.Write(Severity.Fatal, TestFormatResult, null), Times.Once());
        }

        [Fact]
        public void NonNullFormatWithIncorrectArgumentsWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<FormatException>(() => { mock.Object.Fatal(TestFormat, TestFormatArg0); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NullCauseWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Fatal((Exception)null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Fatal(TestException);
            mock.Verify(logger => logger.Write(Severity.Fatal, TestException.GetType().Name, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNullMessageWithFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Fatal(TestException, null); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWithNonNullMessageWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Fatal(TestException, TestMessage);
            mock.Verify(logger => logger.Write(Severity.Fatal, TestMessage, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNullFormatWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<ArgumentNullException>(() => { mock.Object.Fatal(TestException, null, TestFormatArg0, TestFormatArg1); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }

        [Fact]
        public void NonNullCauseWithNonNullFormatWillCallProvider()
        {
            var mock = new Mock<ILogger>();
            mock.Object.Fatal(TestException, TestFormat, TestFormatArg0, TestFormatArg1);
            mock.Verify(logger => logger.Write(Severity.Fatal, TestFormatResult, TestException), Times.Once());
        }

        [Fact]
        public void NonNullCauseWithNonNullFormatWithIncorrectArgumentsWillFail()
        {
            var mock = new Mock<ILogger>();
            Assert.Throws<FormatException>(() => { mock.Object.Fatal(TestException, TestFormat, TestFormatArg0); });
            mock.Verify(logger => logger.Write(It.IsAny<Severity>(), It.IsAny<string>(), It.IsAny<Exception>()), Times.Never());
        }
    }
}
