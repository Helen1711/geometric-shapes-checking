using GeometricShapesChecking.entities;
using GeometricShapesChecking.utils;

namespace GeometricShapesChecking.service
{
    public class CylinderService
    {
        public Cylinder Create()
        {
            double height = InputService.GetParam("Enter height of cylinder");
            double diameter = InputService.GetParam("Enter diameter of cylinder");
            return new Cylinder(height, diameter);
        }
    }
}
