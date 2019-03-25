using GeometricShapesChecking.entities;
using GeometricShapesChecking.utils;

namespace GeometricShapesChecking.service
{
    public class ParallelepipedService
    {
        public Parallelepiped Create()
        {
            double width = InputService.GetParam("Enter width of parallelepiped");
            double height = InputService.GetParam("Enter height of parallelepiped");
            double deep = InputService.GetParam("Enter deep of parallelepiped");
            return new Parallelepiped(width, height, deep);
        }
    }
}
