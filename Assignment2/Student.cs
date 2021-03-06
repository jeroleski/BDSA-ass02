using System;

namespace Assignment2
{
    public class Student
    {
        public int id { get; }
        public string givenName { get; set; }
        public string surName { get; set; }
        public Status status { get; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime graduationDate { get; set; }

        public Student(int id, string GivenName, string Surname, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.givenName = GivenName;
            this.surName = Surname;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = startDate.AddYears(3);

            if (endDate > startDate && endDate < graduationDate)
            {
                this.status = Status.Dropout;
            }
            else if (DateTime.Now > endDate)
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

        public override string ToString()
        {
            return "ID: " + id + " - " + surName + ", " + givenName + "\n" + 
                "STATUS: " + status + " " + startDate.ToString() + " - " + endDate.ToString() + " (" + graduationDate.ToString() + ")";
        }


        public static void Main(string[] args)
        {

        }
    }
}