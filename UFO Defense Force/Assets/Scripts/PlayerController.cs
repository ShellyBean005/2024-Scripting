using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    public Transform blaster;
    public GameObject laser;
    public float laserSpawnRate;
    public bool canFire;
    // Start is called before the first frame update
    void Start()
    {
        canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //leftbounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); ;
        }

        if(transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }

        if(Input.GetButton("Jump") && canFire)
        {
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);
            canFire = false;
            StartCoroutine(Timer());
        }

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(laserSpawnRate);
        canFire = true;
    }


}
