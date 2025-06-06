namespace AnneeBissextile.Test
{
    public class UnitTest1
    {
        private const ushort ImportantValue4 = 4;
        private const ushort ImportantValue100 = 100;
        private const ushort ImportantValue400 = 400;




        [Theory (DisplayName = "Years that are divisible by 400 are always leap years")]
        [InlineData(ImportantValue400)]
        [InlineData(ImportantValue400*2)]
        [InlineData(ImportantValue400*3)]

        public void IsDivisibleBy400(ushort year)
        {
            //Given a year that is divisible by 400
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return true
            Assert.True(isLeap);
        }

        [Theory (DisplayName = "Years that are divisible by 100 but not by 400 are not leap years") ]
        [InlineData(ImportantValue100)]
        [InlineData(ImportantValue100*2)]
        [InlineData(ImportantValue100*5)]

        public void IsDivisibleBy100NotDivisibleBy400(ushort year)
        {
            //Given a year that is divisible by 100 but not by 400
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return false
            Assert.False(isLeap);
        }

        [Theory (DisplayName = "Years that are divisible by 4 and not by 100 are leap years")]
        [InlineData(ImportantValue4)]
        [InlineData(ImportantValue4*2)]
        [InlineData(ImportantValue100+ ImportantValue4)]

        public void IsDivisibleBy4NotDivisibleBy100(ushort year)
        {
            //Given a year that is divisible by 4 but not by 100
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return true
            Assert.True(isLeap);
        }

        [Theory (DisplayName = "Years that are not divisible by 4 are never leap years")]
        [InlineData(ImportantValue4+1)]
        [InlineData(ImportantValue4 - 1)]
        [InlineData(ImportantValue100-1)]
        [InlineData(ImportantValue400+1)]


        public void IsNotDivisibleBy4(ushort year)
        {
            //Given a year that is not divisible by 4 
            //When I check if it is a leap year
            var isLeap = GregorianCalendar.IsLeapYear(year);
            //Then it should return false
            Assert.False(isLeap);
        }

        [Theory (DisplayName = "Years out of range are not leap years")]
        [InlineData(0)]
        [InlineData(ImportantValue400 * -1)]
        [InlineData(ImportantValue4 * -1)]

        public void FalseYears(int year)
        {
            // Given a year of 0 or negative
            // When I check if it is a leap year
            // Then it should return false
            Assert.Throws<ArgumentOutOfRangeException>(() => GregorianCalendar.IsLeapYear(year));
        }

    }
}