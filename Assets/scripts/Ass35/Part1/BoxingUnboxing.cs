using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        private int health = 100;
        void Start()
        {
            Debug.Log($"The original int value: {health}");
            //object health;
            Debug.Log($"The boxed value: {health}");
            health = (int)70;
            Debug.Log($"The unboxed and modified value: {health}");


        }
    }
}