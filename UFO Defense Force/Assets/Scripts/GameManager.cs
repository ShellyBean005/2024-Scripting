using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public GameObject gameOverText;

    private audioCamera mainCamera;
    public AudioClip gameOver;

    public PlayerController playerController;

    void Awake()
    {
        Time.timeScale = 1; //start time on awake
        isGameOver = false;
        mainCamera = GameObject.Find("Main Camera").GetComponent<audioCamera>();
        playerController = GameObject.Find("Player").GetComponent <PlayerController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }

    }

    public void EndGame()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0;//stop time
        mainCamera.cameraSound.mute = true;
        playerController.playerAudio.PlayOneShot(gameOver, 1.0f);
        Debug.Log("GameOver");

    }
}
