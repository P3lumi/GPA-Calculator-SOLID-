using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Week4.Model;

namespace Week4.Data_Access
{
    public interface ICrud
    {
        Task Add(Course _course);
        
    }
}
