using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 targetOffSet;
    [SerializeField]
    private float movementSpeed;
 
    void Start()
    {
        
    }

  
    void Update()
    {
        moveCamera();
    }

    void moveCamera()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + targetOffSet, movementSpeed * Time.deltaTime);
    }
}
