using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class ImplementatioUtilities : MonoBehaviour
    {
        void Start()
        {
            int sum = Utilities.Add(2, 3, 6, 8, 2);
            Debug.Log(sum);
            Utilities.RepeatString("Hello", 5);

        }
    }
}
