using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody rigidBody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = moveVelocity;
    }

}
