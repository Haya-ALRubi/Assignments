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
            Debug.Log($"FibonacciRecursive(10) = {FibonacciRecursive(10)}");
            Debug.Log($"FibonacciIterative(10) = {FibonacciIterative(10)}");
            Debug.Log($"FibonacciRecursive(30) = {FibonacciRecursive(30)}");
            Debug.Log($"FibonacciIterative(30) = {FibonacciIterative(30)}");
        }
        public int FibonacciRecursive(int n)
        {
            return n <= 1 ? n : FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        public int FibonacciIterative(int n)
        {
            List<int> fibonacc = new List<int>() { 0, 1 };
            if (n <= 1) return n;
            for (int i = 2; i <= n; i++)
            {
                int newNumber = fibonacc[i - 1] + fibonacc[i - 2];
                fibonacc.Add(newNumber);
            }

            return fibonacc[n];

        }
    }
}