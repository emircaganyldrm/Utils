using UnityEngine;

namespace emirc.Extensions
{
    public static class TransformExtensions
    {
        public static Transform Reset(this Transform source)
        {
            source.position = Vector3.zero;
            source.rotation = Quaternion.identity;
            source.localScale = Vector3.one;
            return source;
        }

        public static bool IsGrounded(this Transform transform, float height, int playerLayer)
        {
            if (Physics.Raycast(transform.position + Vector3.up, Vector3.down, height, playerLayer))
            {
                return true;
            }

            return false;
        }
        
        public static bool IsGrounded(this Transform transform, float height = 1)
        {
            if (Physics.Raycast(transform.position + Vector3.up, Vector3.down, height))
            {
                return true;
            }

            return false;
        }
    }
}
