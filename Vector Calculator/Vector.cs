using System;

namespace Vector_Calculator
{
    public struct Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public double GetDirection()
        {

            return Math.Atan((y / x));
        }

        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector operator-(Vector v)
        {
            Vector Output = new Vector(v.x, v.y, v.z);
            Output.x -= (v.x * 2);
            Output.y-= (v.y* 2);
            Output.z-= (v.z* 2);
            return Output; 
        }

        public static Vector operator-(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector operator*(Vector v, double scalar)
        {
            return new Vector((v.x * scalar), (v.y * scalar), (v.z * scalar));
        }

        public static Vector Normalize(Vector v)
        {
            //divide each unit by it's magnitude
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static double DotProduct(Vector v1, Vector v2)
        {
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector((v1.y * v2.z) - (v1.z * v2.y), (v1.z * v2.x) - (v1.x * v2.z), (v1.x * v2.y) - (v1.y * v2.x));
        }

        public static double AngleBetween(Vector v1, Vector v2)
        {
            return (Math.Acos(DotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude())));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            double newscalar = DotProduct(v1, v2) / Math.Pow(v2.GetMagnitude(), 2);
            return (v2 * newscalar);
        }
    }
}
