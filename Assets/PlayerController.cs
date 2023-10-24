using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float power = 10;
    public Rigidbody rigidbody;
    public float raycastDistance = 1f;
    private bool isGround;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }

        isGround = Physics.Raycast(transform.position, Vector3.down, raycastDistance);
        if(isGround && Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0, 1, 0) * power);
        }
    }
}
