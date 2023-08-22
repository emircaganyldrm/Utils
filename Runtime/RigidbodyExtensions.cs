using UnityEngine;

namespace emirc.Extensions
{
    public static class RigidbodyExtensions
    {
        public static void ResetMomentum(this Rigidbody rigidbody)
        {
            rigidbody.isKinematic = true;
            rigidbody.isKinematic = false;
        }

        public static void SetDrag(this Rigidbody rigidbody, float value)
        {
            rigidbody.drag = value;
        }
    }
}