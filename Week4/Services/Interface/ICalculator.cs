using System.Collections.Generic;
using Week4.Model;

namespace Week4
{
    public interface ICalculator
    {
        double calculate(List<Course> collect);
    }
}