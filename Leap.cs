public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        else if (year % 100 == 0 && year % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}