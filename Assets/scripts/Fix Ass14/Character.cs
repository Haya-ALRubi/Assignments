using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FixAss14
{
    public class Character
    {

        public string characterName;
        public string CharacterName
        {
            get;
            set;
        }
        private int health;
        public int Health
        {
            get;
            set;
        }
        public Character(string name, int health = 100)
        {
            this.CharacterName = name;
            this.Health = health;
        }


    }
}