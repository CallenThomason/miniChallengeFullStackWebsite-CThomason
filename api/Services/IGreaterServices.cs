using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IGreaterServices
    {
        string CheckOne(int num1, int num2); 
        string CheckTwo(int num1, int num2); 
    }
}