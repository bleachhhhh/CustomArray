using System;
using System.Linq;
using Xunit;

namespace CustomArray.Tests
{
	public class CustomArrayTest
	{
		[Fact]
		public void HasElementCount_Success()
		{
			// Arrange.
			const int expectedElementCount = 10;
			var array = new CustomArray(expectedElementCount);

			// Act.
			var elementCount = array.Length;

			// Assert.
			Assert.Equal(expectedElementCount, elementCount);
		}

		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		public void IvalidLengthCausesException_Success(int expectedElementCount)
		{
			// Act + Assert.
			Assert.Throws<ArgumentException>(() => new CustomArray(expectedElementCount));
		}

		[Fact]
		public void UserValueStoredAndObtainedByIndex_Success()
		{
			// Arrange.
			const int userValue = 123;
			const int userIndex = 5;
			var array = new CustomArray(10);

			array[userIndex] = userValue;

			// Act.
			var actualValue = array[userIndex];

			// Assert.
			Assert.Equal(userValue, actualValue);
		}

		[Fact]
		public void CanFillItselfWithRandomValues_Success()
		{
			// Arrange.
			var array = new CustomArray(100);

			// Act.
			array.SetRandomValues();

			// Assert.
			bool hasNonZeroElement = false;

			for (var i = 0; i < array.Length; i++)
			{
				if ((int)array[i] != 0)
				{
					hasNonZeroElement = true;

					break;
				}
			}

			Assert.True(hasNonZeroElement);
		}

		[Fact]
		public void BonusTest_CanFillItselfWithRandomValues_AsIEnumerableOfInt_Success()
		{
			// Arrange.
			var array = new CustomArray(100);

			// Act.
			array.SetRandomValues();

			// Assert.
			Assert.True(array.Distinct().Count()>1);
		}
	}
}
