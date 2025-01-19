using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class MulticastDelegateExample : MonoBehaviour
    {

        delegate void MathOperation(int number);
        MathOperation operation;
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation.Invoke(5);


        }

        void DoubleNumber(int number)
        {
            int result = number * 2;
            Debug.Log($"Double: {result}");
        }
        void SquareNumber(int number)
        {
            int result = number * number;
            Debug.Log($"Square: {result}");
        }
        void CubeNumber(int number)
        {
            int result = number * number * number;
            Debug.Log($"Cube: {result}");

        }

    }
}