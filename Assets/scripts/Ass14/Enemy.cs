using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
        public void Attack(Character victim, int amount)
    {
        Character.Health -= amount ;
        if (Health < 0)
        {
            Health = 0;
        }
        Debug.Log(CharacterName);
        Debug.Log(Health);
    }
}
