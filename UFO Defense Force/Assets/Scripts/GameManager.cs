using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1; //start time on awake
        isGameOver = false;
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
        Debug.Log("GameOver");
    }
}
