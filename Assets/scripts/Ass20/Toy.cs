using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment20
{
    public class Toy : MonoBehaviour
    {
        public float positonValue = 2f;
        public float rDegree = 0f;
        public float angle = 3f;
        void Start()
        {

        }


        void Update()
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position -= transform.forward * positonValue;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += transform.forward * positonValue;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rDegree += angle;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rDegree -= angle;
            }
            transform.rotation = Quaternion.Euler(new Vector3(0, rDegree, 0));
            if (Input.GetKey(KeyCode.Space))
            {
                transform.position = new Vector3(0, 0, 0);
                rDegree = 0f;
                transform.rotation = Quaternion.Euler(new Vector3(0, rDegree, 0));
            }
        }
    }
}