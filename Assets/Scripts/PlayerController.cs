using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    private GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameManagerScript.isGameActive)
        {
            horizontalInput = Input.GetAxis($"Horizontal");
            forwardInput = Input.GetAxis($"Vertical");

            // Here we move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            //Here we turn the vehicle
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            gameManagerScript.GameOver();
        }
    }
}
