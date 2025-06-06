namespace AnneeBissextile.Test
{
    public class UnitTest1
    {
        [Fact]
        public void IsDivisibleBy400()
        {
            //Given a year that is divisible by 400
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(400);
            //Then it should return true
            Assert.True(isLeap);

        }
    }
}