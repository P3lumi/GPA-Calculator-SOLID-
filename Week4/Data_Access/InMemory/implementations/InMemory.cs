using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Week4.Data_Access.InMemory.interfaces;
using Week4.Model;

namespace Week4.Data_Access.InMemory.interfaces
{
    class InMemory : IInMemory
    {
        public Task Add(Course _course)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
