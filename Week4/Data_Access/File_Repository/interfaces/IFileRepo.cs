using System;
using System.Collections.Generic;
using System.Text;
using Week4.Model;

namespace Week4.Data_Access.File_Repository.interfaces
{
    public interface IFileRepo : ICrud
    {
        void Read();
    }
}
