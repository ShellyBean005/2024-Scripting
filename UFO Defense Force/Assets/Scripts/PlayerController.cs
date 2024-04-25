using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;//player movement
    public float speed;

    public float xRange;//player bounds

    public Transform blaster;//shooting location
    public GameObject laser;

    public float laserSpawnRate; //fire rate
    public bool canFire; 

    public GameManager gameManager; //link gameManager to use script

    // Start is called before the first frame update
    void Start()
    {
        canFire = true;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//ref script
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//get needed WASD

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);//movement

        //Player bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); ;
        }

        if(transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }

        //Shooting
        if(Input.GetButton("Jump") && canFire && gameManager.isGameOver == false)
        {
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);
            canFire = false;
            StartCoroutine(Timer());
        }

    }
    //fire rate timer
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(laserSpawnRate);
        canFire = true;
    }


}
