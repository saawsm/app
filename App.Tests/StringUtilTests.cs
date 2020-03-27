using System;
using Xunit;

namespace Saawsm.App.Tests {

    public class StringUtilTests {

        [Theory]
        [InlineData("A", "B")]
        [InlineData(" A ", " B ")]
        [InlineData(" A", "B")]
        [InlineData("A ", "B")]
        [InlineData("A", " B")]
        [InlineData("A", "B ")]
        [InlineData(" A", " B")]
        [InlineData(" A", "B ")]
        [InlineData("A ", " B")]
        [InlineData("A ", "B ")]
        public void Should_ByDefault_ConcatAndTrim(string firstName, string lastName) {
            const string Expected = "A B";

            string fullName = StringUtil.GetFullName(firstName, lastName);

            Assert.Equal(Expected, fullName);
        }

        [Theory]
        [InlineData("A", null)]
        [InlineData(null, "B")]
        [InlineData(null, null)]
        public void Should_ThrowException_When_NameIsNull(string firstName, string lastName) {
            Assert.Throws<ArgumentNullException>(() => {
                StringUtil.GetFullName(firstName, lastName);
            });
        }

        [Fact]
        public void Should_ByDefault_PerserveCapitalization() {
            const string Expected = "Sa aW";

            string fullName = StringUtil.GetFullName("Sa", "aW");

            Assert.Equal(Expected, fullName);
        }

    }

}
