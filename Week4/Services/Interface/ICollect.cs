using System.Collections.Generic;
using Week4.Model;

namespace Week4
{
    public interface ICollect
    {
         List<Course> courses { get; set; }
        void Input();
    }
}