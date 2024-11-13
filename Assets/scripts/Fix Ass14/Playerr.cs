using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FixAss14
{
    public class Playerr : Character
    {
        public Playerr(string name, int health = 100) : base(name, health)
        {
        }

        public void Heal()
        {
            Health += 5;
            if (Health > 100)
            {
                Health = 100;
            }
            Debug.Log("Player: " + CharacterName + "Health: " + Health);
        }
    }
}