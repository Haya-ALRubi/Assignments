using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        //Fn =(Fn - 1) + (Fn -2)
        void Start()
        {
            Debug.Log(FibonacciRecursive(10));
            Debug.Log(FibonacciIterative(30));
        }
        public int FibonacciRecursive(int n)
        {
            return n <= 1 ? n : FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        public int FibonacciIterative(int n)
        {
            int a = 0, b = 1, result;
            if (n <= 1) return n;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return b;

        }
    }
}