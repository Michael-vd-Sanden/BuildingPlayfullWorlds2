using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded = false;

    Vector3 velocity;

    float xRotation = 0f;
    public Transform playerBody;

    void Update()
    {
        Move();
        Jump();
        CheckIsGrounded();
        //Rotate();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = /*transform.right * x +*/ transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    void CheckIsGrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }

    void Rotate()
    {
        float x = Input.GetAxis("Horizontal");

        xRotation -= x;
        xRotation = Mathf.Clamp(xRotation, -180f, 180f);

        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
        //playerBody.Rotate(Vector3.right * x);
    }
}
