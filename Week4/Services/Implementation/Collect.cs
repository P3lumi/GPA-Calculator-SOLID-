using System;
using System.Collections.Generic;
using System.Text;
using Week4.Data_Access.File_Repository.interfaces;
using Week4.Model;

namespace Week4
{
    public class Collect : ICollect
    {
        public List<Course> courses { get; set; }
        private int score;
        private string code;
        private int unit;
        public IFormula grade;
        public IFileRepo filedb;

        public Collect(IFormula _grade, IFileRepo _db)
        {
            filedb = _db;
            grade = _grade;
            courses = new List<Course>();
        }

        public void Input()
        {
            while (true)
            {
                Console.Write("Enter Course Code: ");
                this.code = Console.ReadLine();
                if (Utility.Validator.StringValidator(code) == true)
                    break;
            }

            while(true)
            {
                try
                {
                    Console.Write("Enter Course Unit: ");
                    this.unit = Convert.ToInt32(Console.ReadLine());
                    if (Utility.Validator.IntValidator(unit) == true)
                        break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("*-----Please Enter A number----*");
                    Utility.Logger.Log(e.Message,e.StackTrace);
                }
                
                
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter Course Score: ");
                    this.score = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("*-----Please Enter A number between 0 and 100----*");
                    Utility.Logger.Log(e.Message, e.StackTrace);
                }
            }
            

            Course _course = new Course();
            _course.CourseCode = code;
            _course.CourseUnit = unit;
            _course.CourseScore = score;
            _course.CourseGrade = grade.allocateGrade(score);
            _course.GradeUnit = grade.allocateGradeUnits(_course.CourseGrade);
            courses.Add(_course);
            filedb.Add(_course);
        }


    }
}
