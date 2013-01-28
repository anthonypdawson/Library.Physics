using System.Collections.Generic;
using System.Linq;


using Microsoft.Xna.Framework;

namespace Library.Physics
{

    public static class Vector2ExtensionMethods
    {
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
            return v1.X + v1.Y > v2.X + v2.Y;
        }

        public static bool IsGreaterThanOrEqual(this Vector2 v1, Vector2 v2)
        {
            return v1.X + v1.Y >= v2.X + v2.Y;
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
