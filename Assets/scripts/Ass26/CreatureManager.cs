using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        public List<Crature> creatures = new List<Crature> { };
        public List<IRunnable> runnables = new List<IRunnable> { };
        public List<IJumpable> jumpables = new List<IJumpable> { };
        public List<ISwimmable> swimmables = new List<ISwimmable> { };
        Kangaroo kangaroo = new Kangaroo();
        Duck duck = new Duck();
        void Start()
        {
            creatures.Add(kangaroo);
            creatures.Add(duck);
            runnables.Add(kangaroo);
            jumpables.Add(kangaroo);
            runnables.Add(duck);
            swimmables.Add(duck);
            foreach (Crature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
        }
    }
}
