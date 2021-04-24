using UnityEngine;

namespace MVCExtensionsLibrary
{
    public static class FloatExtensions
    {
        public static bool Between(this float f, float f_lower, float f_higher)
        {
            float higher = Mathf.Max(f_lower, f_higher);
            float lower = Mathf.Min(f_lower, f_higher);
            
            if (f < higher && f > lower)
                return true;
            else return false;
        }
        
        public static float Remap (this float value, float from1, float to1, float from2, float to2) 
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }

        public static float ClampAngle(this float angle, float from, float to)
        {
            while (angle < 0f)
            {
                angle = 360 + angle;
            }

            while (angle > 360)
            {
                angle = angle - 360;
            }

            if (angle > 180)
            {
                return Mathf.Max(angle, 360 + from);
            }

            return Mathf.Min(angle, to);
        }
    }
}