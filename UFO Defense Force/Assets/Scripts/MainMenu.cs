using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.TextMeshPro;
public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;


    public void StartGame()//attached to Start game and restart buttons
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
