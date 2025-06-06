
namespace AnneeBissextile
{
    public class GregorianCalendar
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            return false;
        }
    }
}
