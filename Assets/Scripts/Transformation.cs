using UnityEngine;

namespace DefaultNamespace
{
    public abstract class Transformation: MonoBehaviour
    {
        public abstract Vector3 Apply(Vector3 point);
    }
}