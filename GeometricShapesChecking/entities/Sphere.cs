namespace GeometricShapesChecking.entities
{
    public class Sphere : IShape
    {
        public double Diameter { set; get; }

        public Sphere(double diameter)
        {
            Diameter = diameter;
        }

        private string positiveAnswer = "Sphere gets in";
        private string negativeAnswer = "Sphere doesn't get in";

        public string GetInCircle(Circle circle)
        {
            if (circle.Diameter > Diameter)
            {
                return positiveAnswer;
            }
            return negativeAnswer;
        }

        public string GetInRectangle(Rectangle rectangle)
        {
            if (rectangle.Height > Diameter && rectangle.Width > Diameter)
            {
                return positiveAnswer;
            }
            return negativeAnswer;
        }
    }
}
