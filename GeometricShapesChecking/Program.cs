using GeometricShapesChecking.service;
using System;

namespace GeometricShapesChecking
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserService service = new UserService();
            service.Choose();
            Console.ReadKey();
        }
    }
}
