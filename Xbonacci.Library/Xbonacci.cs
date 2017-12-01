using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Well met with Fibonacci bigger brother, AKA Tribonacci.

As the name may already reveal, it works basically like a Fibonacci, but summing the last 3 (instead of 2) numbers of the sequence to generate the next. And, worse part of it, regrettably I won't get to hear non-native Italian speakers trying to pronounce it :(

So, if we are to start our Tribonacci sequence with [1, 1, 1] as a starting input (AKA signature), we have this sequence:

[1, 1 ,1, 3, 5, 9, 17, 31, ...]
But what if we started with [0, 0, 1] as a signature? As starting with [0, 1] instead of [1, 1] basically shifts the common Fibonacci sequence by once place, you may be tempted to think that we would get the same sequence shifted by 2 places, but that is not the case and we would get:

[0, 0, 1, 1, 2, 4, 7, 13, 24, ...]
Well, you may have guessed it by now, but to be clear: you need to create a fibonacci function that given a signature array/list, returns the first n elements - signature included of the so seeded sequence.

Signature will always contain 3 numbers; n will always be a non-negative number; if n == 0, then return an empty array and be ready for anything else which is not clearly specified ;)

If you enjoyed this kata more advanced and generalized version of it can be found in the Xbonacci kata

[Personal thanks to Professor Jim Fowler on Coursera for his awesome classes that I really recommend to any math enthusiast and for showing me this mathematical curiosity too with his usual contagious passion :)]*/
namespace Xbonacci.Library
{
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            double[] res = new double[n];
            Array.Copy(signature, res, Math.Min(3, n));

            for (int i = 3; i < n; i++)
                res[i] = res[i - 3] + res[i - 2] + res[i - 1];

            return n == 0 ? new double[] { 0 } : res;

            /*
            if (n == 0)
                return new double[] { 0.0 };
            else
            {
                List<double> temp = new List<double>();
                List<double> resul = new List<double>();
                temp.AddRange(signature);
                resul.AddRange(signature.ToList().GetRange(0,n<3?n:3));
                double new_num = 0;
                for(int i=0;i<n-3;i++)
                {
                    new_num = 0;
                    foreach (double x in temp)
                        new_num += x;

                    resul.Add(new_num);
                    temp.Clear();
                    temp.AddRange(resul
                        .Select((x,j)=>new double[] { x,j })
                        .Where(y=>y[1]>resul.Count-4)
                        .Select(x => x[0]));
                }


                return resul.ToArray();
            }*/
        }
    }
}
