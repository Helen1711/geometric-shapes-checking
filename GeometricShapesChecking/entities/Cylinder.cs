namespace GeometricShapesChecking.entities
{
    public class Cylinder : IShape
    {
        public double Height { set; get; }

        public double Diameter { set; get; }

        public Cylinder(double height, double diameter)
        {
            Height = height;
            Diameter = diameter;
        }

        private string positiveAnswer = "Cylinder gets in";
        private string negativeAnswer = "Cylinder doesn't get in";

        public string GetInCircle(Circle circle)
        {
            if (circle.Diameter > Diameter)
            {
                return positiveAnswer;
            }
            if (circle.Diameter > Diameter && circle.Diameter > Height)
            {
                return positiveAnswer;
            }
            return negativeAnswer;
        }

        public string GetInRectangle(Rectangle rectangle)
        {
            if (rectangle.Height > Height && rectangle.Width > Diameter)
            {
                return positiveAnswer;
            }
            if (rectangle.Height > Diameter && rectangle.Width > Diameter)
            {
                return positiveAnswer;
            }
            if (rectangle.Width > Height && rectangle.Height > Diameter)
            {
                return positiveAnswer;
            }
            return negativeAnswer;
        }
    }
}
