using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;
            if (numbers.Length > 0)
            {
                foreach (int number in numbers)
                {
                    total += number;
                }
            }
            return total;

        }
        public static void RepeatString(this string text, int n)
        {
            string repeatText = "";
            if (n > 0)
            {
                for (int i = 0; i < n; i++) { repeatText += text; }
                Debug.Log(repeatText);
            }
            else Debug.Log(text);

        }

    }
}
