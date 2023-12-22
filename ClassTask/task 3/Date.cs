
class Date
{
    int day;
    int month;
    int year;
    // constructor
    public Date(int _day,int  _month , int _year)
    {
    day = _day;
    month = _month;
    year = _year;
    }
    // ina bo properties
    public int Day
    {
    get { return day;}
    set { day =value;}
    }
    public int Month
    {
    get { return month;}
    set { month =value;}
    }
    public int Year
    {
    get { return year;}
    set { year =value;}
    }
    //method
    public void SetDate(int _day, int _month, int _year)
    {
    day = _day;
    month = _month;
    year = _year;
    }
    public string GetDay()
    {
        if(day < 10) return $"0{day}";
        else return $"{day}";
    }
    public string GetMonth()
    {
        if(day < 10) return $"0{month}";
        else return $"{month}";
    }
    public int GetYear()
    {
        return year;
    }
    public string ToString()
    {
      return $"{GetDay()}/{GetMonth()}/{GetYear()}";
    }
}