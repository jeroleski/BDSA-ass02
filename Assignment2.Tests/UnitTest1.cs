using System;
using Xunit;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void student_is_active_if_started_last_year()
        {
            DateTime oneYearBack = DateTime.Now.AddYears(-1);
            Student student = new Student(1, "Jeppe", "Korgaard", oneYearBack);

            Status expected = Status.Active;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void student_is_graduated_if_started_4_years_ago()
        {
            DateTime fourYearBack = DateTime.Now.AddYears(-4);
            Student student = new Student(1, "Jeppe", "Korgaard", fourYearBack);

            Status expected = Status.Graduated;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void student_is_new_if_starting_in_1_year()
        {
            DateTime oneYearAfter = DateTime.Now.AddYears(1);
            Student student = new Student(1, "Jeppe", "Korgaard", oneYearAfter);

            Status expected = Status.New;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }






    }
}
