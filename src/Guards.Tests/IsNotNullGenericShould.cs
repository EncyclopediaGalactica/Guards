namespace EncyclopediaGalactica.Guards.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using FluentAssertions;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class IsNotNullGenericShould
    {
        [Fact]
        public void ThrowWhenGenericIsNull()
        {
            // Arrange
            TypeA typeA = null;
            
            // Act
            Action action = () => { Guards.Check.IsNotNull(typeA); };
            
            // Assert
            action.Should().ThrowExactly<GuardException>();
        }
        
        [Fact]
        public void DoesntThrow_WhenGenericIsNull()
        {
            // Arrange
            TypeA typeA = new TypeA();
            
            // Act
            Action action = () => { Guards.Check.IsNotNull(typeA); };
            
            // Assert
            action.Should().NotThrow<GuardException>();
        }
    }

    internal class TypeA
    {
    }
}