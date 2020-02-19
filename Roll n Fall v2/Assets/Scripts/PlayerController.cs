using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody player;

    private float k = 1;
    public float jumpHeight = 1000f;
    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 MovementVector = new Vector3(MoveHorizontal, 0f, MoveVertical);

        if (Input.GetButtonDown("Jump"))
        {
            print("HERE");
            player.AddForce(Vector3.up * jumpHeight);
            print(Vector3.up);
            print(Vector3.up * jumpHeight);
        }

        player.AddForce(MovementVector * k);
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
