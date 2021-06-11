namespace IsItALeapYear
{
    public  class Program
    {
        static void Main()
        {
        }
        public bool IsItALeapYear(int Year)
        {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
