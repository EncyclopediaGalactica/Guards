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
        
        [Fact]
        public void DoesntThrow_WhenValuesArentEqual()
        {
            // Arrange
            long one = 1;
            long two = 2;

            // Act
            Action action = () => { Check.AreNotEqual(one, two); };

            // Assert
            action.Should().NotThrow<GuardException>();
        }

        [Fact]
        public void ThrowExceptionWhenValuesAreEqual_LongIsNullable()
        {
            // Arrange
            long? one = 1;
            long one_not_nullable = 1;
            
            // Act
            Action action = () => { Check.AreNotEqual(one, one_not_nullable); };
            
            // Assert
            action.Should().ThrowExactly<GuardException>();
        }
        
        [Fact]
        public void DoesntThrowException_WhenValuesAreEqual_LongIsNullable()
        {
            // Arrange
            long? one = 1;
            long one_not_nullable = 2;
            
            // Act
            Action action = () => { Check.AreNotEqual(one, one_not_nullable); };
            
            // Assert
            action.Should().NotThrow<GuardException>();
        }
    }
}