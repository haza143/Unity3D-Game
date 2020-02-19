using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody player;

    public bool isGrounded = false;

    public int jumpHeight;

    public void FixedUpdate()
    {
        print(isGrounded);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            player.AddForce(Vector3.up * jumpHeight);
        }

        if (Input.GetButtonDown("ChangeMass"))
        {
            if(player.mass == 1){
                player.mass = 0.5f;
            }else{
                player.mass = 1;
            };
        }

        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        direction = Camera.main.transform.TransformDirection(direction);
        direction.y = 0.0f;
        
        player.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}