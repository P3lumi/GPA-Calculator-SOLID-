using System;
using System.Collections.Generic;
using System.Text;
using Week4.Model;

namespace Week4
{
    public class Design : IDesign
    {
        ICalculator gpa;
        public Design( ICalculator _gpa)
        {
            gpa = _gpa;
        }

        public void Screen(List<Course> input)
        {
            Console.WriteLine("|---------------|---------------|---------------|----------------|");
            Console.WriteLine("|  COURSE CODE  |  COURSE UNIT  |     GRADE     |   GRADE UNIT   |");
            Console.WriteLine("|---------------|---------------|---------------|----------------|");
            input.ForEach((c) => { Console.WriteLine($"|  { c.CourseCode}        |    {c.CourseUnit}      |   {c.CourseGrade}     |   {c.GradeUnit}   |"); });


            Console.WriteLine($"Your GPA is = {gpa.calculate(input)}");
            Console.WriteLine("\n\n\n\n\n\n\n\n");

        }


        public void Message()
        {
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|      Hi, Welcome to Grade Calculator         |");
            Console.WriteLine("|----------------------------------------------|");

            Console.WriteLine("/n");


            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|      Enter the next course         |");
            Console.WriteLine("|------------------------------------|");
        }



    }
}
