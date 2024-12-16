using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class CallValueRefOut : MonoBehaviour
    {
        public int a = 20;
        public int b = 13;
        void Start()
        {
            Debug.Log($"a = {a}");
            Debug.Log($"b = {b}");
            ValueMethod(a);
            Debug.Log($"a after ValueMethod = {a}");
            RefMethod(ref b);
            Debug.Log($"b after RefMethod = {b}");
            OutMethod(out a);
            Debug.Log($"a after OutMethod = {a}");

        }
        public void ValueMethod(int para)
        {
            para += 5;
        }
        public void RefMethod(ref int para)
        {
            para += 5;
        }
        public void OutMethod(out int para)
        {
            para = 3;
        }

    }
}
