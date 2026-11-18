using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class GreaterServices : IGreaterServices
    {
        public string CheckOne(int num1, int num2)
        {
             if(num1 == num2)
            {
               return $"{num1} = {num2}"; 
            }
            else if(num1 > num2)
            {
                 return $"{num1} > {num2}"; 
            }
            else
            {
                  return $"{num1} < {num2}"; 
            }
        }
         public string CheckTwo(int num1, int num2)
        {
             if(num1 == num2)
            {
               return $"{num2} = {num1}"; 
            }
            else if(num1 > num2)
            {
                 return $"{num2} < {num1}"; 
            }
            else
            {
                  return $"{num2} > {num1}"; 
            }
        }
    }
}