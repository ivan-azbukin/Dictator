using System;
using Dictator;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class RocketTests
    {
        [Fact]
        public void GetAmmoLevel_CorrectInput_ReturnsCorrectLevel()
        {
            //arrange
            var ammoNumber = 17;
            var true_level = 6;
            var rocket = new Rocket();
            
            //act
            var level = rocket.GetAmmoLevel(ammoNumber);
            
            //assert
            level.Should().Be(true_level);
        }

        [Fact]
        public void GetAmmoLevel_AmmoNumberLessThen1_ThrowsArgumentException()
        {
            //arrange
            var ammoNumber = 0;
            var rocket = new Rocket();
            
            //act
            Func<int> act = () => rocket.GetAmmoLevel(ammoNumber);
            
            //assert
            act.Should().Throw<ArgumentException>();
        }
        
        [Fact]
        public void GetAmmoLevel_AmmoNumberGreaterThen108_ThrowsArgumentException()
        {
            //arrange
            var ammoNumber = 109;
            var rocket = new Rocket();
            
            //act
            Func<int> act = () => rocket.GetAmmoLevel(ammoNumber);
            
            //assert
            act.Should().Throw<ArgumentException>();
        }
    }
}