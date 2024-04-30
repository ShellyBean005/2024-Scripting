using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;//attach scoremanger

    public PlayerController playerController;

    public int scoreToGive;

    public AudioClip hitSound;
    private AudioSource UFOsource;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent< ScoreManager >();//ref score manager
        UFOsource = GetComponent<AudioSource>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);//increase score through manager

        //Destroy both objects in collision
        Destroy(gameObject);
        Destroy(other.gameObject);
        playerController.playerAudio.PlayOneShot(hitSound,1.0f);
    }
}
