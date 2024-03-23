namespace Geometry
{
    public class Vector
    {
        public double X;
        public double Y;
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            Vector sum = new() { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y};
            return sum;
        }
    }
}