using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;//attach scoremanger
 
    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent< ScoreManager >();//ref score manager
    }
    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);//increase score through manager

        //Destroy both objects in collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
