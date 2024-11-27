using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
namespace Assignment19
{
    public class PendulmMovement : MonoBehaviour
    {
        public float speed = 1.5f;
        public float limit = 75f;
        public GameObject[] pendulums;

        void Start()
        {


        }

        void Update()
        {
            float displacment = 0.0f;
            foreach (GameObject pendulum in pendulums)
            {
                float angle = limit * Mathf.Sin(Time.time * speed + displacment);
                pendulum.transform.localRotation = Quaternion.Euler(0, 0, angle);
                displacment += 0.5f;


            }
        }
    }
}