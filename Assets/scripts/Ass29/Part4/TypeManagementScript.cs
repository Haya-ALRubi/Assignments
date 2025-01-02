using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public interface ICanFight
    {
        public void Attack();
    }
    public class TypeManagementScript : MonoBehaviour
    {
        List<ICanFight> canFightsObjects = new List<ICanFight> { new Cat(), new Warrior() };
        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();
            (animal as Cat)?.MakeSound();
            (animal as Cat)?.Move();

            foreach (ICanFight fightObject in canFightsObjects)
            {
                fightObject.Attack();
            }
            foreach (ICanFight fighter in canFightsObjects)
            {
                if (fighter is Cat) Debug.Log("The object is a Cat.");
                if (fighter is Warrior) Debug.Log("The object is a Warrior.");
            }

        }
        public class Animal
        {
            public virtual void MakeSound() => Debug.Log("Animal sound");
            public void Move() => Debug.Log("Animal moves.");
        }
        public class Cat : Animal, ICanFight
        {
            public override void MakeSound() => Debug.Log("Meow!");
            public new void Move() => Debug.Log("Cat runs quickly.");
            public void Attack() => Debug.Log("Cat attacks with claws!");
        }
        public class Warrior : ICanFight
        {
            public void Attack() => Debug.Log("Warrior attacks with a sword!");
        }
    }
}
