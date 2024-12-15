using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assignment25Test;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
namespace Assignment25
{
    public class BookPopUp : MonoBehaviour
    {
        public Transform pageOne;
        public Transform ajala;
        public Transform ajalaScale;
        public Transform ajalaRotate;

        public Transform[] elements;
        private bool isOpening = false;
        private bool isClosing = false;
        public float maxAngle = 0f;
        public float minAngle = -180f;
        private float currentRotation = -180f;
        public float ajalaMaxAngle = 0f;
        public float ajalaMinAngle = -45f;
        private float ajalaCurrentRotation = -45f;
        private float currentRotationElements = -180f;
        private float currentPosition = 0f;
        private float currentScale = 0f;
        public float speed = 10f;
        private float timer = 0f;

        public Vector3 elementScale = new Vector3(0.01f, 0.01f, 0.01f);
        void Start()
        {
        }

        void Update()
        {
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

                currentRotation += speed * Time.deltaTime * 5;
                currentRotation = Mathf.Clamp(currentRotation, minAngle, maxAngle);
                ajalaCurrentRotation += speed * Time.deltaTime * 5;
                ajalaCurrentRotation = Mathf.Clamp(ajalaCurrentRotation, ajalaMinAngle, ajalaMaxAngle);

                pageOne.localRotation = Quaternion.Euler(0, 0, currentRotation);
                ajala.localRotation = Quaternion.Euler(0, 0, ajalaCurrentRotation);
                currentRotationElements -= speed * Time.deltaTime * 5;
                currentRotationElements = Mathf.Clamp(currentRotationElements, minAngle, maxAngle);
                currentScale = Mathf.Lerp(0f, 1f, currentRotationElements / minAngle);
                ajalaScale.localScale = new Vector3(currentScale, currentScale, currentScale);
                Camera.main.fieldOfView = Mathf.Lerp(85, 65, currentRotationElements * 4 / minAngle);

                foreach (Transform element in elements)
                {
                    element.localScale = new Vector3(1, currentScale, 1);
                }
                if (currentRotation >= maxAngle)
                {
                    isOpening = false;

                }
            }
            if (isOpening == false)
            {
                ajalaRotate.Rotate(Vector3.forward, Time.deltaTime * speed * 5, Space.Self);
            }
            //Close Book
            if (isClosing)
            {

                currentRotation -= speed * Time.deltaTime * 5;
                currentRotation = Mathf.Clamp(currentRotation, minAngle, maxAngle);
                ajalaCurrentRotation -= speed * Time.deltaTime * 5;
                ajalaCurrentRotation = Mathf.Clamp(ajalaCurrentRotation, ajalaMinAngle, ajalaMaxAngle);
                //Camera.main.fieldOfView = Mathf.Lerp(85, 65, currentRotation * 4 / maxAngle);

                pageOne.localRotation = Quaternion.Euler(0, 0, currentRotation);
                ajala.localRotation = Quaternion.Euler(0, 0, ajalaCurrentRotation);
                currentRotationElements += speed * Time.deltaTime * 5;
                currentRotationElements = Mathf.Clamp(currentRotationElements, minAngle, maxAngle);
                currentScale = Mathf.Lerp(0f, 1f, currentRotationElements / minAngle);
                ajalaScale.localScale = new Vector3(currentScale, currentScale, currentScale);
                Camera.main.fieldOfView = Mathf.Lerp(85, 65, currentRotationElements * 4 / minAngle);
                foreach (Transform element in elements)
                {
                    element.localScale = new Vector3(1, currentScale, 1);
                }
                if (currentRotation <= minAngle)
                {
                    isClosing = false;
                }

            }


        }
    }

}
