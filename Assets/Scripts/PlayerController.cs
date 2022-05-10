using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject centerOfMass;

    [SerializeField] float horsePower = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        playerRB.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Here we move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        playerRB.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
        
        //Here we turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
       
    }
}
