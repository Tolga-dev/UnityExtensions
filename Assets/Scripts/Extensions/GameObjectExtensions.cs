using UnityEngine;

namespace Extensions
{
    public static class GameObjectExtensions
    {
        public static T AddComponentIfMissing<T>(this GameObject gameObject) where T : Component
        {
            var component = gameObject.GetComponent<T>();
            if (component == null)
            {
                component = gameObject.AddComponent<T>();
                Debug.Log("Added A Component" + typeof(T).Name);
            }
            return component;
        }
    }
    
}