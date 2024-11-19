using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
namespace Ass18Part2
{
    public class Inventory
    {
        private List<string> items;
        public Inventory()
        {
            items = new List<string>();
        }
        public void AddItem(string item)
        {
            items.Add(item);
        }
        public void ShowItems()
        {
            foreach (string item in items)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory inventoryOne, Inventory inventoryTwo)
        {
            Inventory combined = new Inventory();
            combined.items.AddRange(inventoryOne.items);
            combined.items.AddRange(inventoryTwo.items);
            return combined;
        }

    }
}