using System;
using System.Collections.Generic;
using System.Linq;
using Library.Physics.Controllers;

namespace Library.Physics
{
    public class World
    {
        List<PhysicsController> Controllers { get; set; }
    }

    public sealed class PConstants
    {
        /// <summary>
        /// PI.
        /// </summary>
        //public const float Pi = 3.14159265359f;
        public const float Pi = (float)Math.PI;

        public const float MaxFloat = 3.402823466e+38f;

        //public const float PiOver2 = 1.570796326794f;
        public const float E = (float)Math.E;
        public const float Log10E = 0.4342945f;
        public const float Log2E = 1.442695f;

        public const float PiOver2 = (float)(Math.PI / 2.0);
        public const float PiOver4 = (float)(Math.PI / 4.0);
        public const float TwoPi = (float)(Math.PI * 2.0);

        /// <summary>
        /// A small value often used to decide if numeric 
        /// results are zero.
        /// </summary>
        public const float Epsilon = 1.192092896e-07f;
    }

    public sealed class PMath
    {
        /// <summary>
        /// Gets the square root.
        /// </summary>
        /// <param name="number">The number to get the square root from.</param>
        /// <returns></returns>
        #region public static float Sqrt(float number)
        public static float Sqrt(float number)
        {
            return (float)Math.Sqrt(number);
        }

        public static float Max(float[] numbers)
        {
            return numbers.Max();
        }

        public static float Min(float[] numbers)
        {
            return numbers.Min();
        }

        public static float Clamp(float value, float min, float max)
        {
            value = (value > max) ? max : value;
            value = (value < min) ? min : value;
            return value;
        }

        // This method uses double precission internally,
        // though it returns single float
        // Factor = 180 / pi
        public static float ToDegrees(float radians)
        {            
            return (float)(radians * 57.295779513082320876798154814105);
        }

        // This method uses double precission internally,
        // though it returns single float
        // Factor = pi / 180
        public static float ToRadians(float degrees)
        {            
            return (float)(degrees * 0.017453292519943295769236907684886);
        }

        #endregion
    }
}
