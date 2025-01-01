using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(DateTime.Now.Date);
            Debug.Log(DateTime.Now.TimeOfDay);
            Debug.Log(DateTime.Now.DayOfWeek);
            var number = 17;
            var text = "Zaytona";
            var isZaytona = true;
            Debug.Log(number >= 0 && number % 2 == 1 ? $"The number {number} is odd." : $"The number {number} is even.");

        }
    }
}