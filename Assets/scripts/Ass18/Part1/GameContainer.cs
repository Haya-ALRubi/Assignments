using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ass18Part1
{
    public class GameContainer<T>
    {
        private T item;
        public void SetItem(T item)
        {
            this.item = item;
        }
        public T GetItem()
        {
            return item;
        }
    }

    public class GameUtils
    {
        public static string DescribeItem<T>(T something)
        {
            return ("This item is a " + something);
        }
    }
}