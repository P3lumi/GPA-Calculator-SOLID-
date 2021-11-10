using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Week4.Model;

namespace Week4.Data_Access.InMemory.interfaces
{
    public interface IInMemory:ICrud
{
        void Read();
    }
}
