using System;

namespace GeometricShapesChecking.entities
{
    public class Parallelepiped : IShape
    {
        public double Width { set; get; }

        public double Height { set; get; }

        public double Deep { set; get; }

        public Parallelepiped(double width, double height, double deep)
        {
            Width = width;
            Height = height;
            Deep = deep;
        }

        private string positiveAnswer = "Parallelepiped gets in";
        private string negativeAnswer = "Parallelepiped doesn't get in";

        public double CalculateTopDiagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Deep, 2));
        }

        public double CalculateSideDiagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

        public double CalculateOppositeDiagonal()
        {
            return Math.Sqrt(Math.Pow(Deep, 2) + Math.Pow(Height, 2));
        }

        public string GetInCircle(Circle circle)
        {
            if (circle.Diameter > CalculateOppositeDiagonal())
            {
                return positiveAnswer;
            }

            if (circle.Diameter > CalculateTopDiagonal())
            {
                return positiveAnswer;
            }

            if (circle.Diameter > CalculateSideDiagonal())
            {
                return positiveAnswer;
            }
            return negativeAnswer;
        }

        public string GetInRectangle(Rectangle rectangle)
        {
            if (rectangle.Height > Height && rectangle.Width > Width)
            {
                return positiveAnswer;
            }

            if (rectangle.Width > Width && rectangle.Height > Deep)
            {
                return positiveAnswer;
            }

            if (rectangle.Width > Height && rectangle.Height > Width)
            {
                return positiveAnswer;
            }
            return negativeAnswer;
        }
    }
}
