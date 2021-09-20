using System;

namespace Assignment2
{
    public record ImmutableStudent
    {
        public int id { get; init; }
        public string givenName { get; init; }
        public string surName { get; init; }
        public Status status { get; init; }
        public DateTime startDate { get; init; }
        public DateTime endDate { get; init; }
        public DateTime graduationDate { get; init; }

        public ImmutableStudent(int id, string GivenName, string Surname, DateTime startDate, DateTime endDate)
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
    }
}