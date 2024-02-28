using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25f;
    private float turnSpeed = 50f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Get WASD inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Forward movement based on WS
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Didn't want the car to rotate without forward movement-cuz cars dont DO that- found this online- seems to work
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            //Rotation-Side movement based on AD
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        }
               
    }


}
