using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class Implemntation : MonoBehaviour
    {
        CustomObject Object1 = new CustomObject(1, "Coffee");
        CustomObject Object2 = new CustomObject(2, "Karak tea");
        void Start()
        {
            print($"{Object1} == {Object2} is {Object1 == Object2}.");
            print($"{Object1} != {Object2} is {Object1 != Object2}.");
        }
    }
}
