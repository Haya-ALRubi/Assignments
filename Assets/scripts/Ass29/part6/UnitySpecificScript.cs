using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{

    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject targetObject;
        public GameObject joker;
        public Light light;
        void OnEnable() => print("GameObject Enabled");
        void Start()
        {
            print("Game started!");
            targetObject = GameObject.Find("TargetObject");
            joker = GameObject.FindGameObjectWithTag("Joker");
            light = GameObject.FindObjectOfType<Light>();
            print(targetObject != null ? $" Found object by name:{targetObject.name}" : "No TargetObject found.");
            print(joker != null ? $"Found object by tag: {joker.name}" : "No Joker object found.");
            print(light != null ? $"Found object of type Light: {light.name}" : "No light object found.");
        }


        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D))
            {
                print("TargetObject deactivated!");
                targetObject.SetActive(false);
            }
        }
        void OnDisable() => print("GameObject Disabled");
    }
}
