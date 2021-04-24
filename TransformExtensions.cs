using UnityEngine;

namespace MVCExtensionsLibrary
{
    public static class TransformExtensions
    {
        public static void DeleteAllChildren(this Transform transform)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject.Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
}