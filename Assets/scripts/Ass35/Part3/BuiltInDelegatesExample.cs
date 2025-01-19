using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action logMessage = () => Debug.Log("Hello from Action delegate!");
        Func<int, int> square = (num) => num * num;
        Predicate<int> isEven = (int i) => i % 2 == 0;
        void Start()
        {
            logMessage();
            Debug.Log($"Square: {square(5)}");
            Debug.Log($"Is 4 even? {isEven(4)}");


        }

    }
}