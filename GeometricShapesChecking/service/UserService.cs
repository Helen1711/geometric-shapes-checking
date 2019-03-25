using GeometricShapesChecking.entities;
using GeometricShapesChecking.utils;
using System;

namespace GeometricShapesChecking.service
{
    public class UserService
    {
        private Rectangle rectangle;
        private Circle circle;
        private string result;

        public void Choose()
        {
            double canalType = InputService.GetParam("Choose type of canal: 1 for rectangle or 2 for circle.");
            if (canalType == 1)
            {
                RectangleService service = new RectangleService();
                rectangle = service.Create();
            }
            else if (canalType == 2)
            {
                CircleService service = new CircleService();
                circle = service.Create();
            }
            else
            {
                Console.WriteLine("value Doesn't exist.");
            }
            double shapeType = InputService.GetParam("Choose type of shape: 1 for parallelepiped, " +
                "2 for cylinder or 3 for sphere.");
            if (shapeType == 1)
            {
                ParallelepipedService service = new ParallelepipedService();
                Parallelepiped parallelepiped = service.Create();
                if (canalType == 1)
                {
                    result = parallelepiped.GetInRectangle(rectangle);
                }
                else
                {
                    result = parallelepiped.GetInCircle(circle);
                }
            }
            else if (shapeType == 2)
            {
                CylinderService service = new CylinderService();
                Cylinder cylinder = service.Create();
                if (canalType == 1)
                {
                    result = cylinder.GetInRectangle(rectangle);
                }
                else
                {
                    result = cylinder.GetInCircle(circle);
                }
            }
            else if (shapeType == 3)
            {
                SphereService service = new SphereService();
                Sphere sphere = service.Create();
                if (canalType == 1)
                {
                    result = sphere.GetInRectangle(rectangle);
                }
                else
                {
                    result = sphere.GetInCircle(circle);
                }
            }
            else
            {
                Console.WriteLine("value Doesn't exist.");
            }
            Console.WriteLine(result);
        }
    }
}
