using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    public float RotationsSpeed = 5.0f;

    public float SmoothFactor = 0.1f;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("MoveCamera") * RotationsSpeed, Vector3.up);
            offset = camTurnAngle * offset;

            Vector3 newPos = player.transform.position + offset;

            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

            transform.LookAt(player.transform);
       

       
    }
}
