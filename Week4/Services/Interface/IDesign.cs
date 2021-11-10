using System.Collections.Generic;
using Week4.Model;

namespace Week4
{
    public interface IDesign
    {
        void Message();
        void Screen(List<Course> input);
    }
}