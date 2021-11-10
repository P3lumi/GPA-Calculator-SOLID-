using System;
using System.Collections.Generic;
using System.Text;

namespace Week4
{
    public class Formula : IFormula
    {

        //grading system(assigning points to grade)


        //int sumGrade = 0;

        //assigning grade to scores
        public char allocateGrade(int score)

        {
            if (score >= 70 && score <= 100)
            {
                return 'A';
            }
            else if (score >= 60 && score <= 69)
            {
                return 'B';
            }
            else if (score >= 50 && score <= 59)
            {
                return 'C';
            }
            else if (score >= 45 && score <= 49)
            {
                return 'D';
            }
            else if (score >= 40 && score <= 44)
            {
                return 'E';
            }
            else
            {
                return 'F';
            }
        }


        public int allocateGradeUnits(char grade)

        {
            if (grade =='A')
            {
                return 5;
            }
            else if (grade == 'B')
            {
                return 4;
            }
            else if (grade == 'C')
            {
                return 3;
            }
            else if (grade == 'D')
            {
                return 2;
            }
            else if (grade == 'E')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
