using UnityEngine;
namespace Assignment37
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        Rigidbody rigidbody;
        Vector3 input;
        bool jump = false;
        float speed = 3f;

        void Start()
        {

            rigidbody = GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
        }

        void Update()
        {

            input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, -Input.GetAxisRaw("Vertical"));
            input = input.normalized * speed;
            input.y = rigidbody.velocity.y;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = true;
            }

        }
        void FixedUpdate()
        {

            if (jump)
            {
                rigidbody.drag = 1f;
                //rigidbody.mass = 1.5f;
                rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
                jump = false;
            }
            else
            {
                rigidbody.drag = 0;
                // rigidbody.mass = 1f;
                rigidbody.velocity = input;
            }
        }
    }
}
