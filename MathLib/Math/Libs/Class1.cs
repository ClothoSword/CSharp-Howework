using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public struct Vector
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public Vector(float x =0.0f,float y=0.0f,float z=0.0f)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector(Vector v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        public static Vector operator+(Vector v1,Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator-(Vector v1,Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator*(Vector v,float num)
        {
            return new Vector(v.X * num, v.Y * num, v.Z * num);
        }

        public static Vector operator *(float num,Vector v)
        {
            return new Vector(v.X * num, v.Y * num, v.Z * num);
        }

        public static Vector operator/(Vector v,float num)
        {
            if (num == 0)
            {
                throw new Exception("Division by 0");
            }
            return new Vector(v.X / num, v.Y / num, v.Z / num);
        }

        public static float Dot(Vector v1,Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z + v2.Z;
        }

        public static Vector Cross(Vector v1,Vector v2)
        {
            return new Vector(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public override string ToString()
        {
            return $"x:{X},y:{Y},z:{Z}";
        }

        public override int GetHashCode()
        {
            int hashCode = X.GetHashCode();
            hashCode ^= Y.GetHashCode();
            hashCode ^= Z.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (this.GetType() != obj.GetType())
                return false;
            return Equals((Vector)obj);
        }

        public bool Equals(Vector obj)
        {
            return ((obj != null) && (Math.Abs(X - obj.X) < 0.01f) && (Math.Abs(Y - obj.Y) < 0.01f) && (Math.Abs(Z - obj.Z) < 0.01f));
        }

        public static bool operator==(Vector left,Vector right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }
            return left.Equals(right);
        }

        public static bool operator!=(Vector left,Vector right)
        {
            return !(left == right);
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public Vector normalized()
        {
            return new Vector( this / Magnitude());
        }
    }
}
