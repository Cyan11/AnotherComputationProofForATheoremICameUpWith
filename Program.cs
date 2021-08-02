using System;
using System.Collections.Generic;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 1500;
            while (true)
            {
                List<OrderedPair> Solutions = new List<OrderedPair>();
                Solutions = BruteForce(target);
                int answer;
                answer = CalculateUsingFormula(target);
                if (Solutions.Count == answer)
                {
                    Console.WriteLine("target:" + target + ", Using My Answer: " + answer + ", Using Brute Force: " + Solutions.Count + " -- Sucess!" );
                    target++;
                }
                else
                {
                    Console.WriteLine("target:" + target + ", Using My Answer: " + answer + ",Using Brute Force: " + Solutions.Count + " -- Failure!");
                    break;
                }
                if(target == 11500)
                {
                    Console.WriteLine("target:" + target + ", Using My Answer: " + answer + ",Using Brute Force: " + Solutions.Count + " -- Test Ended Succesfully!");
                    break;
                }
            }
        }
        static List<OrderedPair> BruteForce(int t)
        {
            List<OrderedPair> ops = new List<OrderedPair>();
            for (int i = 0; i < t+1; i++)
            {
                for (int j = 0; j < t + 1; j++)
                {
                    for (int k = 0; k < t + 1; k++)
                    {
                        if(i+j+k == t)
                        {
                            ops.Add(new OrderedPair(i, j, k));
                        }
                    }
                }
            }
            return ops;
        }
        static int CalculateUsingFormula(int t)
        {
            if(t%2==1)
                return ((t + 1) / 2) * (t + 2);
            else
            {
                return (((t + 1) / 2) * (t + 2)) + ((t + 2) / 2) ;
            }
        }
        static int CalculateUsingThiagosMethod(int t)
        {
            //Dunno yet
            return 0;
        }
    }
    
    class OrderedPair
    {
        public int x;
        public int y;
        public int z;

        public OrderedPair(int _x, int _y, int _z)
        {
            x = _x;y = _y;z = _z;
        }
    }
}
