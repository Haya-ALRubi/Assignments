using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Ass18Part1
{
    public class GenericsTest : MonoBehaviour
    {

        void Start()
        {
            GameContainer<string> container = new GameContainer<string>();
            container.SetItem("Healing potion");
            string stored = container.GetItem();
            Debug.Log("Stored item:" + stored);
            string describtion = GameUtils.DescribeItem(stored);
            Debug.Log(describtion);


        }


    }
}
