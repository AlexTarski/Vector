namespace Geometry
{
    public class Vector
    {
        public double X;
        public double Y;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector v)
        {
            return Geometry.Add(this, v);
        }

        public bool Belongs(Segment s)
        {
            return Geometry.IsVectorInSegment(this, s);
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector v)
        {
            return Geometry.IsVectorInSegment(v, this);
        }
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));
        }

        public static double GetLength(Segment segment)
        {
            return Math.Sqrt(((segment.End.X - segment.Begin.X) * (segment.End.X - segment.Begin.X)) + ((segment.End.Y - segment.Begin.Y) * (segment.End.Y - segment.Begin.Y)));
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            Vector sum = new() { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y};
            return sum;
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            var AB = GetLength(segment);
            var AX = GetLength(new Segment { Begin = segment.Begin, End = vector});
            var XB = GetLength(new Segment {  End = segment.End, Begin = vector });
            return AX + XB == AB;
        }
    }
}