using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.TextMeshPro;
public class MainMenu : MonoBehaviour
{
    private AudioSource buttonAudioSource;
    public AudioClip RestartSound;
    public AudioClip QuitSound;

    public int sceneToLoad;
    public void Start()
    {
        buttonAudioSource = GetComponent<AudioSource>();
    }

    public void StartGame()//attached to Start game and restart buttons
    {
        StartCoroutine(WaitRestart());
        buttonAudioSource.PlayOneShot(RestartSound, 1.0f);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        buttonAudioSource.PlayOneShot(QuitSound, 1.0f);
        StartCoroutine(WaitQuit());
    }

    public IEnumerator WaitRestart()
    {
       yield return new WaitForSecondsRealtime(3);
       SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded");

    }

    public IEnumerator WaitQuit()
    {
        yield return new WaitForSecondsRealtime(3);
        Application.Quit();
    }
}
