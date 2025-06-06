
namespace AnneeBissextile
{
    public class GregorianCalendar
    {
        public static bool IsLeapYear(int year)
        {

            if (year <= 0) throw new ArgumentOutOfRangeException(nameof(year));

            return (year % 4 == 0) && (year % 4 == 0 && year % 100 != 0) && !(year % 100 == 0 && year % 400 != 0) || year % 400 == 0;
        }
    }
}
