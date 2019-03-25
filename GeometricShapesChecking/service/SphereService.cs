using GeometricShapesChecking.entities;
using GeometricShapesChecking.utils;

namespace GeometricShapesChecking.service
{
    public class SphereService
    {
        public Sphere Create()
        {
            double diameter = InputService.GetParam("Enter diameter of sphere");
            return new Sphere(diameter);
        }
    }
}
