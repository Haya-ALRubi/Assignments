using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.Health = health;
            this.position = position;
        }
        public Character() : this("No name", 100, new Position(0, 0, 0)) { }
        public virtual void DisplayInfo()
        {
            Debug.Log("Name: " + name + "Health: " + health);
            position.PrintPosition();
        }
        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
        }
        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log(attackType);
            Attack(damage, target);
        }

    }
}