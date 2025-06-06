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


    }
}