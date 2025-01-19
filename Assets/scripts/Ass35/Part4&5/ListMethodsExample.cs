using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new List<int>() { 1, 15, 11, 5, 7 };
        List<int> numbers2 = new List<int>() { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers;
        void Start()
        {
            Debug.Log("Before: " + string.Join(", ", numbers));
            numbers.Sort((int x, int y) => y.CompareTo(x));
            Debug.Log("After: " + string.Join(", ", numbers));
            filteredNumbers = (numbers2.FindAll((int i) => i % 2 == 0));
            Debug.Log("List2: " + string.Join(", ", numbers2));
            Debug.Log("Even numbers: " + string.Join(", ", filteredNumbers));

        }

    }
}