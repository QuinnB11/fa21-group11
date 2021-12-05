using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15.0f;
    public float gravity = -9.81F;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.8f;
    public float deathDistance = 0.2f;
    public LayerMask groundMask;
    bool isGrounded;
    public float moveSpeed = 5F;


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);



        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);


        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(1.5f * -2f * gravity); 

        }

        velocity.y += gravity * Time.deltaTime;


        controller.Move(velocity * Time.deltaTime);

    }

}
