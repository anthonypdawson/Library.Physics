using System;
using System.Collections.Generic;
using System.Linq;


using Microsoft.Xna.Framework;

namespace Library.Physics
{

    public class Vector : IComparer<Vector>
    {
        public float X;
        public float Y;
        public Vector2 Vector2;
        public Vector(float x, float y)
        {
            X = x;
            Y = y;          
            Vector2 = new Vector2(x, y);
        }

        public Vector(float i) : this(i, i)
        {            
        }

        public Vector(Vector2 vector2) : this (vector2.X, vector2.Y)
        {
            
        }
        public Vector Flip()
        {
            return new Vector(X, X*-1);
        }

        public float Length
        {
            get { return Vector2.Length(); }
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(Vector2.Multiply(v1.Vector2, v2.Vector2));
        }

        public static Vector operator /(Vector v1, Vector v2)
        {
            return new Vector(Vector2.Divide(v1.Vector2, v2.Vector2));
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector source, Vector value)
        {
            return new Vector(source.X - value.X, source.Y - value.Y);
        }

        public static Boolean operator >(Vector v1, Vector v2)
        {
            return v1.Vector2.IsGreaterThan(v2.Vector2);
        }
        public static Boolean operator >=(Vector v1, Vector v2)
        {
            return v1.Vector2.IsGreaterThanOrEqual(v2.Vector2);
        }
        public static Boolean operator <=(Vector v1, Vector v2)
        {
            return v1.Vector2.IsLessThanOrEqual(v2.Vector2);
        }
        public static Boolean operator <(Vector v1, Vector v2)
        {
            return v1.Vector2.IsLessThan(v2.Vector2);
        }

        public int Compare(Vector x, Vector y)
        {
            return (int) (x.Length - y.Length);
        }
    }

    public static class VectorExtensions
    {
        public static Vector Min(this ICollection<Vector> collection)
        {
            return collection.OrderByDescending(v => v.Length).Last();
        }

        public static Vector Max(this ICollection<Vector> collection)
        {
            return collection.OrderByDescending(v => v.Length).First();
        }
    }

    public static class Vector2ExtensionMethods
    {

        public static Vector2 Flip(this Vector2 v)
        {
            return new Vector2(v.Y, v.X * -1);
        }

        public static Vector2 Add(this Vector2 v1, Vector2 v2)
        {
            return Vector2.Add(v1, v2);
        }

        public static Vector2 Subtract(this Vector2 source, Vector2 value)
        {            
            return Vector2.Subtract(source, value);
        }

        public static Vector2 Min(this List<Vector2> collection)
        {
            Vector2 minVector = collection.First();
            minVector = collection.Aggregate(minVector, (current, c) => c.IsGreaterThan(current) ? c : current);

            return minVector;
        }

        public static Vector2 Max(this List<Vector2> collection)
        {
            Vector2 maxVector = collection.First();
            maxVector = collection.Aggregate(maxVector, (current, c) => c.IsLessThan(current) ? c : current);

            return maxVector;
        }

        public static bool IsGreaterThan(this Vector2 v1, Vector2 v2)
        {
            return v1.Length() > v2.Length();
        }

        public static bool IsGreaterThanOrEqual(this Vector2 v1, Vector2 v2)
        {
            return v1.Length() >= v2.Length();
        }

        public static bool IsLessThan(this Vector2 v1, Vector2 v2)
        {
            return v2.IsGreaterThan(v1);
        }

        public static bool IsLessThanOrEqual(this Vector2 v1, Vector2 v2)
        {
            return v2.IsGreaterThanOrEqual(v1);
        }
    }

    public class Vector2Helper
    {
        public Vector2 Vector2 { get; private set; }


        public Vector2Helper(Vector2 v)
        {
            Vector2 = v;            
        }

        public static implicit operator Vector2Helper(Vector2 v2)
        {
            return new Vector2Helper(v2);
        }

        public static Vector2Helper operator +(Vector2Helper v1, Vector2 v2)
        {
        
            return new Vector2(v1.Vector2.X + v2.X, v1.Vector2.Y + v2.Y);
        }
    }
}
