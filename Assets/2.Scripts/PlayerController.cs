using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region [SerializeField]
    [SerializeField] float speed = 10.0f;
    [SerializeField] float turnSpped = 27.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;
    #endregion
    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        // 차량 전진
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpped * horizontalInput * Time.deltaTime);

    }
}
