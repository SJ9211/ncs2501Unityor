﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed;
    public float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input

        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * rotationSpeed);
    }
}
