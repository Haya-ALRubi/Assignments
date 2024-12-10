using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
namespace Assignment25
{
    public class PopUpAnimation : MonoBehaviour
    {
        public Transform pageOne;
        public Transform pageTwo;
        public Transform diorama;
        public Transform oneElemnts;
        public Transform TwoElemnts;
        public float maxAngle = 90f;
        private float currentRotation = 0f;
        public float speed = 20f;
        private bool isRotating = true;
        public float rotationSpeed = 10f;
        public float rotationDuration = 20f;
        private float rotationTimer = 0f;
        private Quaternion intialRotaion;
        private bool isReturning = false;

        private float timer = 0f;
     
        public Vector3 elementScale = new Vector3(0.01f, 0.01f, 0.01f);
        void Start()
        {
            intialRotaion = transform.rotation;
            diorama.localScale = new Vector3(0, 1, 1);

            oneElemnts.localScale = new Vector3(0, 1, 1);
            TwoElemnts.localScale = new Vector3(0, 1, 1);

        }

        // Update is called once per frame
        void Update()
        {
            if (isRotating)
            {
                rotationTimer += Time.deltaTime;
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * 2);
                if (rotationTimer >= rotationDuration)
                {
                    isRotating = false;
                    isReturning = true;
                    rotationTimer = 0f;
                }
            }
            else if (isReturning)
            {
                rotationTimer += Time.deltaTime;
                transform.rotation = Quaternion.Lerp(transform.rotation, intialRotaion, rotationTimer);
                //if (rotationTimer >= 1f)
                //{
                //    transform.rotation = intialRotaion;
                //    isReturning = false;
                // }
            }

            timer += Time.deltaTime;

            if (Input.GetMouseButton(0) && currentRotation < maxAngle)
            {
                float rotationStep = speed * Time.deltaTime * 2;
                currentRotation += rotationStep;
                pageOne.Rotate(Vector3.forward, rotationStep);
                pageTwo.Rotate(Vector3.forward, -rotationStep);
                if (oneElemnts.localScale.x < 1f)
                {
                    oneElemnts.localScale += new Vector3(elementScale.x, 0, 0) * rotationStep * 2;
                    oneElemnts.localScale = new Vector3(Mathf.Min(oneElemnts.localScale.x, 1f), oneElemnts.localScale.y, oneElemnts.localScale.z);
                }
                if (TwoElemnts.localScale.x < 1f)
                {
                    TwoElemnts.localScale += new Vector3(elementScale.x, 0, 0) * rotationStep * 2;
                    TwoElemnts.localScale = new Vector3(Mathf.Min(TwoElemnts.localScale.x, 1f), TwoElemnts.localScale.y, TwoElemnts.localScale.z);
                }

                if (diorama.localScale.x < 1f)
                {
                    diorama.localScale += new Vector3(elementScale.x, 0, 0) * rotationStep * 1.2f;
                    diorama.localScale = new Vector3(Mathf.Min(diorama.localScale.x, 1f), diorama.localScale.y, diorama.localScale.z);
                }


            }

        }
    }

}
