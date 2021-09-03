/*Given a year, return the century it is in. 
The first century spans from the year 1 up to and including the year 100, 
the second - from the year 101 up to and including the year 200, etc.*/
int centuryFromYear(int year) {
    int siglo = 0;
    if(year%2 == 0)
    {
        year = year - 1;
    }
    if (year >= 1 && year <= 2005)
    {
        float sigloFloat = year/100 +1;
        siglo = (int) Math.Round(sigloFloat);
        return siglo;
    }
    return siglo;
}