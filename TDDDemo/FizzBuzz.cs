using System;
using System.Collections.Generic;
using System.Text;

namespace TDDDemo
{
    class FizzBuzz
    {
       public string GetFizzBuzz(int num)
        {
            if(num % 5 ==0 && num % 3 == 0)
            {
                return "fizzbuzz";
            }
            else if(num % 5 == 0)
            {
                return "fizz";
            }
            else if(num %3==0)
            {
                return "buzz";
            }
            else
            {
                return "";
            }
            
        }

    }
}
