using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment25
{

    public class CameraMovement : MonoBehaviour
    {
        public Transform target;
        public float rotationSpeed = 100f;
        private Vector3 initialPosition;
        public float verticalSpeed = 2f;
        public float minVerticalAngle = -30f;
        public float maxVerticalAngle = 60f;
        private float currentVertical = 0f;
        private float currentHorizontal = 0f;

        void Start()
        {
            initialPosition = transform.position;
        }


        void Update()
        {
            //float mouseY = Input.GetAxis("Mouse Y");
            //float mouseX = Input.GetAxis("Mouse X");
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticallInput = Input.GetAxis("Vertical");
            //currentVertical -= mouseY * verticalSpeed;
            //currentVertical = Mathf.Clamp(currentVertical, minVerticalAngle, maxVerticalAngle);
            //currentHorizontal += mouseX * verticalSpeed;
            // transform.eulerAngles = new Vector3(currentVertical, currentHorizontal, 0);
            transform.RotateAround(target.position, Vector3.up, -horizontalInput * rotationSpeed * Time.deltaTime);
            Vector3 direction = (transform.position - target.position);
            transform.position += direction * -verticallInput * Time.deltaTime;
            if (horizontalInput != 0 || verticallInput != 0)
            {
                transform.LookAt(target);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                transform.position = initialPosition;
            }



        }
    }
}
