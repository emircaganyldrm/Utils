using System.Collections.Generic;
using UnityEngine;

namespace emirc.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Returns the closest element in a MonoBehaviour list
        /// </summary>
        /// <param name="source"></param>
        /// <param name="to">Position to check the distance to</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>Closest element</returns>
        public static T GetClosest<T>(this List<T> source, Vector3 to) where T : MonoBehaviour
        {
            float closestDistance = 999;
            T closestElement = null;
            
            foreach (T t in source)
            {
                float distance = Vector3.Distance(to, t.transform.position);
                
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestElement = t;
                }
            }

            return closestElement;
        }
    }

}