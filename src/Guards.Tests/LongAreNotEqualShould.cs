namespace EncyclopediaGalactica.Guards.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class LongAreNotEqualShould
    {
        [Fact]
        public void ThrowExceptionWhenValuesAreEqual()
        {
            // Arrange
            long one = 1;

            // Act
            Action action = () => { Check.AreNotEqual(one, one); };

            // Assert
            action.Should().ThrowExactly<GuardException>();
        }
    }
}