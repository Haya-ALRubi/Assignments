using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Burst.Intrinsics;
using UnityEngine;
namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        public class ChainingByHaya
        {
            Transform transform;
            public ChainingByHaya(Transform transform) => this.transform = transform;
            public ChainingByHaya SetPosition(Vector3 position)
            {
                transform.position = position;
                return this;
            }
            public ChainingByHaya SetRotation(Vector3 rotation)
            {
                transform.rotation = Quaternion.Euler(rotation);
                return this;
            }
            public ChainingByHaya SetScale(Vector3 scale)
            {
                transform.localScale = scale;
                return this;
            }
            public ChainingByHaya Apply() => this;

        }
        void Start()
        {
            ChainingByHaya chaining = new ChainingByHaya(transform);
            chaining.SetPosition(new Vector3(0, 1, 0))
                  .SetRotation(new Vector3(45, 0, 0))
                  .SetScale(new Vector3(2, 2, 2)).Apply();
            Debug.Log($"TheGameObject's position will be updated to: {transform.position}");
            Debug.Log($" Its rotation will be set to {transform.eulerAngles.x} on the X-axis.");
            Debug.Log($"Its scale will be updated to: {transform.localScale}");

        }

    }
}