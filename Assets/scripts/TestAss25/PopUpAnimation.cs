using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
namespace Assignment25Test
{
    public class PopUpAnimation : MonoBehaviour
    {
        public Transform pageOne;
        //public Transform pageTwo;
        // public Transform diorama;
        //public Transform oneElemnts;
        // public Transform TwoElemnts;
        public Transform cottage;
        public Transform[] elements;
        private float cotageRotation = 0f;
        private float cottageMaxAngle = 90f;
        private float cottageMinAngle = 0f;
        private bool isOpening = false;
        private bool isClosing = false;
        public float maxAngle = 180f;
        public float minAngle = 0f;
        private float currentRotation = 0f;
        private float currentPosition = 0f;
        public float speed = 10f;
        private float currentScale = 0f;
        private float cotageScale = 0f;
        private bool isRotating = true;
        public float rotationSpeed = 20f;
        public float rotationDuration = 2f;
        private float rotationTimer = 0f;
        private Quaternion intialRotaion;
        private bool isReturning = false;

        private float timer = 0f;

        public Vector3 elementScale = new Vector3(0.01f, 0.01f, 0.01f);
        void Start()
        {
            intialRotaion = transform.rotation;
            //elements.localScale = new Vector3(0, 1, 1);
            // diorama.localScale = new Vector3(0, 1, 1);

            //oneElemnts.localScale = new Vector3(0, 1, 1);
            //TwoElemnts.localScale = new Vector3(0, 1, 1);
            ////
        }

        void Update()
        {

            timer += Time.deltaTime;
            //Open Book
            if (Input.GetMouseButtonDown(0))
            {
                isOpening = true;
                isClosing = false;
            }
            if (Input.GetMouseButtonDown(1))
            {
                isOpening = false;
                isClosing = true;
            }
            if (isOpening)
            {

                currentRotation += speed * Time.deltaTime * 2;
                cotageRotation += speed * Time.deltaTime * 2;
                currentRotation = Mathf.Clamp(currentRotation, minAngle, maxAngle);
                Camera.main.fieldOfView = Mathf.Lerp(85, 65, currentRotation * 4 / maxAngle);
                cotageRotation = Mathf.Clamp(cotageRotation, cottageMinAngle, cottageMaxAngle);
                cottage.localRotation = Quaternion.Euler(0, 0, cotageRotation);
                float rotationStep = speed * Time.deltaTime;
                pageOne.localRotation = Quaternion.Euler(0, 0, currentRotation);
                //pageTwo.localRotation = Quaternion.Euler(0, 0, -currentRotation);

                currentPosition = Mathf.Lerp(0.556f, 0.011f, currentRotation / maxAngle);
                cottage.localPosition = new Vector3(-0.1f, currentPosition, 0);
                currentScale = Mathf.Lerp(0f, 1f, currentRotation * 3 / maxAngle);
                cotageScale = Mathf.Lerp(0f, 1f, currentRotation * 3 / maxAngle);
                cottage.localScale = new Vector3(cotageScale, cotageScale, cotageScale);
                foreach (Transform element in elements)
                {
                    element.localScale = new Vector3(currentScale, 1, 1);
                }
                if (currentRotation >= maxAngle)
                {
                    isOpening = false;
                }
                //Close Book
            }
            if (isClosing)
            {

                currentRotation -= speed * Time.deltaTime * 2;
                currentRotation = Mathf.Clamp(currentRotation, minAngle, maxAngle);
                cotageRotation -= speed * Time.deltaTime * 2;
                Camera.main.fieldOfView = Mathf.Lerp(85, 65, currentRotation * 4 / maxAngle);
                float rotationStep = speed * Time.deltaTime;
                pageOne.localRotation = Quaternion.Euler(0, 0, currentRotation);
                //pageTwo.localRotation = Quaternion.Euler(0, 0, -currentRotation);
                cotageRotation = Mathf.Clamp(cotageRotation, cottageMinAngle, cottageMaxAngle);
                cottage.localRotation = Quaternion.Euler(0, 0, cotageRotation);
                currentPosition = Mathf.Lerp(0.556f, 0.011f, currentRotation / maxAngle);
                cottage.localPosition = new Vector3(-0.1f, currentPosition, 0);
                currentScale = Mathf.Lerp(0f, 1f, currentRotation * 3 / maxAngle);
                cotageScale = Mathf.Lerp(0f, 1f, currentRotation * 3 / maxAngle);
                cottage.localScale = new Vector3(cotageScale, cotageScale, cotageScale);
                foreach (Transform element in elements)
                {
                    element.localScale = new Vector3(currentScale, 1, 1);
                }
                if (currentRotation <= minAngle)
                {
                    isClosing = false;
                }

            }



            ////////////////////////////////
            //if (oneElemnts.localScale.x < 1f)
            // {
            //oneElemnts.localScale += new Vector3(elementScale.x, 0, 0) * rotationStep * 2;
            //    oneElemnts.localScale = new Vector3(Mathf.Min(oneElemnts.localScale.x, 1f), oneElemnts.localScale.y, oneElemnts.localScale.z);
            // }
            // if (TwoElemnts.localScale.x < 1f)
            // {
            //TwoElemnts.localScale += new Vector3(elementScale.x, 0, 0) * rotationStep * 2;
            //     TwoElemnts.localScale = new Vector3(Mathf.Min(TwoElemnts.localScale.x, 1f), TwoElemnts.localScale.y, TwoElemnts.localScale.z);
            // }

            //if (diorama.localScale.x < 1f)
            //  {
            // diorama.localScale += new Vector3(elementScale.x, 0, 0) * rotationStep * 1.2f;
            //   diorama.localScale = new Vector3(Mathf.Min(diorama.localScale.x, 1f), diorama.localScale.y, diorama.localScale.z);
            //  }




        }
    }
    //if (isRotating)
    //  {
    //    rotationTimer += Time.deltaTime;
    //  transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * 3);
    //if (rotationTimer >= rotationDuration)
    //{
    //  isRotating = false;
    //isReturning = true;
    // rotationTimer = 0f;
    // }
    //  }
    //else if (isReturning)
    //  {
    //    rotationTimer += Time.deltaTime;
    ///  transform.rotation = Quaternion.Lerp(transform.rotation, intialRotaion, rotationTimer);
    // if (rotationTimer >= 1f)
    //{
    //   transform.rotation = intialRotaion;
    // isReturning = false;
    //}
    // }

}
