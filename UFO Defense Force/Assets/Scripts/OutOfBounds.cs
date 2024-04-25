using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float topBounds;
    public float bottomBounds;


    public GameManager gameManager;//attach gameManager

    void Awake()
    {
       
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//ref gameManagerScript


    }

  
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBounds)
        {
            gameManager.EndGame();//use EndGame in gameManager script on bottom bounds
            Destroy(gameObject);

        }
    }
}
