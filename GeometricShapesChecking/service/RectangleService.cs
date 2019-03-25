using GeometricShapesChecking.entities;
using GeometricShapesChecking.utils;

namespace GeometricShapesChecking.service
{
    public class RectangleService
    {
        public Rectangle Create()
        {
            double width = InputService.GetParam("Enter width of rectangle");
            double height = InputService.GetParam("Enter height of rectangle");
            return new Rectangle(width, height); ;
        }
    }
}
