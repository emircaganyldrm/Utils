using UnityEngine;

namespace emirc.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 Direction(this Vector3 vector3, Vector3 to)
        {
            return vector3 - to;
        }
        
        public static Vector3 AddX(this Vector3 vector3, float value)
        {
            Vector3 newVector = vector3;
            newVector.x += value;

            vector3 = newVector;

            return vector3;
        }
        
        public static Vector3 AddY(this Vector3 vector3, float value)
        {
            Vector3 newVector = vector3;
            newVector.y += value;

            vector3 = newVector;

            return vector3;
        }
        
        public static Vector3 AddZ(this Vector3 vector3, float value)
        {
            Vector3 newVector = vector3;
            newVector.z += value;

            vector3 = newVector;

            return vector3;
        }
        
        public static Vector3 SetX(this Vector3 vector3, float value)
        {
            Vector3 newVector = vector3;
            newVector.x = value;

            vector3 = newVector;

            return vector3;
        }
        
        public static Vector3 SetY(this Vector3 vector3, float value)
        {
            Vector3 newVector = vector3;
            newVector.y = value;

            vector3 = newVector;

            return vector3;
        }
        
        public static Vector3 SetZ(this Vector3 vector3, float value)
        {
            Vector3 newVector = vector3;
            newVector.z = value;

            vector3 = newVector;

            return vector3;
        }
    }
}