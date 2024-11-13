using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FixAss14
{
    public class Enemy : Character
    {
        public Enemy(string name, int health = 100) : base(name, health)
        {
        }
        public void Attack(Character victim, int amount)
        {
            victim.Health -= amount;
            if (Health < 0)
            {
                Health = 0;
            }
            Debug.Log("Enemy: " + CharacterName + "Attaced Victim: " + victim.CharacterName + " " + "Victime's health now is " + " " + victim.Health);
        }
    }
}