using System;
using Xunit;

namespace OOP1.Tests
{
    public class ArrayHelperTest
    {
        [Fact]
        public void Frecventa_WhenArrayIsNull_ReturnsZero()
        {
            //arrange
            int[] array1 = null;

            //act
            int result = ArrayHelper.Frecventa(array1, 1);

            //assert
            Assert.Equal(0, result);
        }
    }
}
