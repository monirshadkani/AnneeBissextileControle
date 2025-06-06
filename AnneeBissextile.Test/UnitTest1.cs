namespace AnneeBissextile.Test
{
    public class UnitTest1
    {




        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        [InlineData(1200)]
        [InlineData(1600)]

        public void IsDivisibleBy400(ushort year)
        {
            //Given a year that is divisible by 400
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return true
            Assert.True(isLeap);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(500)]

        public void IsDivisibleBy100NotDivisibleBy400(ushort year)
        {
            //Given a year that is divisible by 100 but not by 400
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return false
            Assert.False(isLeap);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(104)]

        public void IsDivisibleBy4NotDivisibleBy100(ushort year)
        {
            //Given a year that is divisible by 4 but not by 100
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return true
            Assert.True(isLeap);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(405)]
        [InlineData(99)]
        [InlineData(101)]
        [InlineData(199)]
        [InlineData(2100)]

        public void IsNotDivisibleBy4(ushort year)
        {
            //Given a year that is not divisible by 4 
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return false
            Assert.False(isLeap);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-4)]

        public void FalseYears(int year)
        {
            // Given a year of 0 or negative
            // When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            // Then it should return false
            Assert.False(isLeap);
        }

    }
}