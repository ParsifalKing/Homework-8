public class Student
{
    string name;
    int age;
    double averageGrade;

    public Student(string _name, int _age, double _averageGrade)
    {
     name = _name;
     age = _age;
     averageGrade = _averageGrade;
    }
    //method
    public string GetInfo()
    {
        return $"Имя: {name}\nВозраст: {age}\nСредняя оценка: {averageGrade}" ;
    }
    public bool IsExcellentStudent()
    {
        if( averageGrade > 4.0) return true;
        else return false;   
    }
}