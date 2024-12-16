using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class Crature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound");
        }
    }
    //Interfaces
    public interface IRunnable
    {
        public void Run();
    }
    public interface IJumpable
    {
        public void Jump();
    }
    public interface ISwimmable
    {
        public void Swim();
    }
    //Classes
    public class Kangaroo : Crature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says : Hop!");
        }
    }
    public class Duck : Crature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says : Quack!");
        }
    }


}