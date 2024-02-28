using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 Direction;
    private bool isJumping;
    float velocity;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumPForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        Direction.y = gravity * Time.deltaTime;
        transform.position = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, verticalInput * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            Direction.y = -gravity * Time.deltaTime;
            _characterController.Move(Direction * Time.deltaTime);
            Debug.Log("Jumping");
        }
        else if (isJumping == true)
        {
            isJumping= false;
            Direction.y = jumPForce;
            Debug.Log("NOW");

        };
        if (_characterController.isGrounded)
        {
            Direction.y = 0;
            Debug.Log("Grounded");
        }
    }

}
