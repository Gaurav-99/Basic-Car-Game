using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 12f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player Movement Input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        
        // Moves the car forward based on Vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates the car based on Horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
