using System;
using System.Collections.Generic;
using System.Text;

namespace Week4.Model
{
    public class Course
    {
        private string courseCode;
        public string CourseCode 
        { 
            get { return courseCode; }
            set { courseCode = value; }
        }


        private int courseUnit;
        public int CourseUnit
        {
            get { return courseUnit; }
            set { courseUnit = value; }
        }

        private int courseScore;
        public int CourseScore
        {
            get { return courseScore; }
            set { courseScore = value; }
        }

        private char courseGrade;
        public  char CourseGrade
        {
            get { return courseGrade; }
            set { courseGrade = value; }
        }

        private int gradeUnit;
        public int GradeUnit
        {
            get { return gradeUnit; }
            set { gradeUnit = value; }
        }

    }
}
