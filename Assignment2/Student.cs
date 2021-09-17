using System;

public class Student
{
    public int id { get; }
    public string givenName { get; set; }
    public string surName { get; set; }
    public Status status { get; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public DateTime graduationDate { get; set; }

    public Student(int id, string GivenName, string Surname, DateTime startDate)
    {
        this.id = id;
        this.givenName = GivenName;
        this.surName = Surname;
        this.startDate = startDate;
        this.graduationDate = startDate.AddYears(3);

        if (DateTime.Now > graduationDate)
        {
            this.status = Status.Graduated;
        }
        else if (DateTime.Now < startDate)
        {
            this.status = Status.New;
        }
        else
        {
            this.status = Status.Active;
        }
    }




    public static void main(string[] args)
    {

    }
}