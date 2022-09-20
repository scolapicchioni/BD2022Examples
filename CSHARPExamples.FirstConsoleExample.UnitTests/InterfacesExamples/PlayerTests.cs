using CSHARPExamples.FirstConsoleExample.InterfacesExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.UnitTests.InterfacesExamples {
    public class PlayerTests {
        [Fact]
        public void Play_ShouldSetScore_WithTwoDiceRolls() {
            //Arrange
            
            Player sut = new Player(new FakeDice());

            //Act
            sut.Play();

            //Assert
            Assert.Equal(10, sut.Score);
        }
    }

    class FakeDice : IDice {
        public int Roll() {
            return 5;
        }
    }

    //SOLID principles

}
