using GeometricShapesChecking.entities;
using GeometricShapesChecking.utils;

namespace GeometricShapesChecking.service
{
    public class CircleService
    {
        public Circle Create()
        {
            double diameter = InputService.GetParam("Enter diameter of circle");
            return new Circle(diameter); ;
        }
    }
}
