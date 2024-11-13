using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        Character[] characters = new Character[2];
        void Start()
        {
            characters[0] = new Soldier("Soldier", 100, new Position(1, 1, 1));
            characters[1] = new Officer("Officer", 100, new Position(0, 0, 0));
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }
            Debug.Log("Before attack, Soldier's health = " + characters[0].Health);
            characters[1].Attack(20, characters[0], "Shooting");
            Debug.Log("After attack, Soldier's health = " + characters[0].Health);

        }

    }
}