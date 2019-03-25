using System;

namespace GeometricShapesChecking.utils
{
    public class InputService
    {
        public static double GetParam(string str)
        {
            Console.WriteLine(str);
            try
            {
                double num = Convert.ToDouble(Console.ReadLine());
                if (num > 0)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Value must be greater than 0");
                    GetParam(str);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid param");
                GetParam(str);
            }
            return 0.0;
        }
    }
}
