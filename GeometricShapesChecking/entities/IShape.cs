namespace GeometricShapesChecking.entities
{
    public interface IShape
    {
        string GetInCircle(Circle circle);

        string GetInRectangle(Rectangle rectangle);

    }
}
