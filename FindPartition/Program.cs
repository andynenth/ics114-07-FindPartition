using System;

namespace FindPartition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setOfTargets = new []{2, 1, 3};
            int[] setOfNumbers = new []{4, 19, -3, 2, 5, 3, 1, 10};
            
            Console.WriteLine(FindPartition(setOfTargets, setOfNumbers));
            
            setOfTargets = new []{6, 2, 9};
            setOfNumbers = new []{9, 0, 14, -3, 2, 1};
            Console.WriteLine(FindPartition(setOfTargets, setOfNumbers));
        }

        static bool FindPartition(int[] setOfTargets, int[] setOfNumbers)
        {
            bool allFound = true;
            foreach (int target in setOfTargets)
            {
                bool theNumberIsExist = false;
                Console.Write("{");
                foreach (int number in setOfNumbers)
                {
                    Console.Write(" " + number);
                    theNumberIsExist = theNumberIsExist || (target == number);
                }
                Console.Write(" }");
                Console.WriteLine(" contains {0} is {1}", target, theNumberIsExist);
                allFound = allFound && theNumberIsExist;
            }
            return allFound;
        }
    }
}
