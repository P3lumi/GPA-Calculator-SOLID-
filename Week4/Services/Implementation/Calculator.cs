using System;
using System.Collections.Generic;
using System.Text;
using Week4.Model;

namespace Week4
{
    public class Calculator : ICalculator
    {

        public int qualityPoints = 0;

        int totalCreditsUnits = 0;


        enum gradingSystem
        {
            A = 5,
            B = 4,
            C = 3,
            D = 2,
            E = 1,
            F = 0
        }

        //method to calculate

        public double calculate(List<Course> collect)
        {
            foreach (Course _course in collect)
            {
                totalCreditsUnits += _course.CourseUnit;
                if (_course.CourseGrade == 'A')
                {
                    qualityPoints += (int)gradingSystem.A * _course.CourseUnit;

                }
                else if (_course.CourseUnit == 'B')
                {
                    qualityPoints += (int)gradingSystem.B * _course.CourseUnit;
                }
                else if (_course.CourseUnit == 'C')
                {
                    qualityPoints += (int)gradingSystem.C + _course.CourseUnit;
                }
                else if (_course.CourseUnit == 'D')
                {
                    qualityPoints += (int)gradingSystem.D + _course.CourseUnit;
                }
                else if (_course.CourseUnit == 'E')
                {
                    qualityPoints += (int)gradingSystem.E + _course.CourseUnit;
                }
                else if (_course.CourseUnit == 'F')
                {
                    qualityPoints += (int)gradingSystem.F + _course.CourseUnit;
                }

            }


            double gpa = (double)qualityPoints / totalCreditsUnits;
            return gpa;
        }


    }
}
