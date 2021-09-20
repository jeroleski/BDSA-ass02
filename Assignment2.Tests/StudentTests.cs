using System;
using Xunit;

namespace Assignment2.Tests
{
    public class StudentTests
    {
        [Fact]
        public void student_is_active_if_started_last_year()
        {
            DateTime oneYearBack = DateTime.Now.AddYears(-1);
            DateTime twoYearAfter = DateTime.Now.AddYears(2);
            Student student = new Student(1, "Jeppe", "Korgaard", oneYearBack, twoYearAfter);

            Status expected = Status.Active;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void student_is_graduated_if_started_4_years_ago()
        {
            DateTime fourYearBack = DateTime.Now.AddYears(-4);
            DateTime oneYearBack = DateTime.Now.AddYears(-1);

            Student student = new Student(1, "Jeppe", "Korgaard", fourYearBack, oneYearBack);

            Status expected = Status.Graduated;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void student_is_new_if_starting_in_1_year()
        {
            DateTime oneYearAfter = DateTime.Now.AddYears(1);
            DateTime fourYearsAfter = DateTime.Now.AddYears(4);
            Student student = new Student(1, "Jeppe", "Korgaard", oneYearAfter, fourYearsAfter);

            Status expected = Status.New;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void student_is_dropout_if_finished_after_1_year()
        {
            DateTime now = DateTime.Now;
            DateTime oneYearAfter = DateTime.Now.AddYears(1);
            Student student = new Student(1, "Jeppe", "Korgaard", now, oneYearAfter);

            Status expected = Status.Dropout;
            Status actual = student.status;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void student_toString_returns_a_nice_string()
        {
            DateTime now = DateTime.Now;
            DateTime threeYearAfter = DateTime.Now.AddYears(3);
            Student student = new Student(1, "Jeppe", "Korgaard", now, threeYearAfter);

            string expected = "ID: 1 - Korgaard, Jeppe\nSTATUS: Active " + now.ToString() + " - " + threeYearAfter.ToString() + " (" + now.AddYears(3).ToString() + ")";
            string actual = student.ToString();

            Assert.Equal(expected, actual);
        }

    }
}
