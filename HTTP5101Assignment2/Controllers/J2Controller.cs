using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment2.Controllers
{
    /* Objectives
     * Suppose we have a number like 12. Let’s define shifting a number to mean adding a zero at the
    end. For example, if we shift that number once, we get the number 120. If we shift the number
    again we get the number 1200. We can shift the number as many times as we want.
    In this problem you will be calculating a shifty sum, which is the sum of a number and the numbers
    we get by shifting. Specifically, you will be given the starting number N and a non-negative integer
    k. You must add together N and all the numbers you get by shifting a total of k times

    For example, the shifty sum when N is 12 and k is 1 is: 12 + 120 = 132. As another example, the
    shifty sum when N is 12 and k is 3 is 12 + 120 + 1200 + 12000 = 13332.
    /// This question was taken from https://cemc.math.uwaterloo.ca/contests/computing/2017/stage%201/juniorEF.pdf

    */

    /// <summary>
    /// Revieves two inputs from a user and adds a certain number of zero's to the end of it and calculates the sum of all the numbers
    /// </summary>
    /// <param name="n">The base number that we are adding zero's to the end of</param>
    /// <param name="k">The number of times a zero will be added to the end of the base number</param>
    /// <example>GET api/J2/ShiftySum/12/3 --> 13332</example>
    /// <returns>The total sum of the base number added by a certain amount of zero's based on the "k" parameter</returns>

    public class J2Controller : ApiController
    {
        [Route("api/J2/ShiftySum/{n}/{k}")]
       public double GetShiftySum(int n, int k)
        {
            double sum = 0;
          
            for (int i = 0; i <=k; i++)
            {
                sum += n * Math.Pow(10,i); 

            }

            return sum;

            
        }

    }
}
