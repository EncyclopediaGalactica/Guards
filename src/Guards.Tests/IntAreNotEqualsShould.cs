namespace EncyclopediaGalactica.Guards.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class IntsAreNotEqualShould
    {
        [Fact]
        public void ThrowExceptionWhenValuesAreEqual()
        {
            // Arrange
            int hundred = 100;

            // Act
            Action action = () => { Check.AreNotEqual(hundred, hundred); };

            // Assert
            action.Should().ThrowExactly<GuardException>();
        }
        
        [Fact]
        public void DoesntThrowException_WhenValuesAreEqual()
        {
            // Arrange
            int hundred = 100;
            int two = 2;

            // Act
            Action action = () => { Check.AreNotEqual(hundred, two); };

            // Assert
            action.Should().NotThrow<GuardException>();
        }
    }
}