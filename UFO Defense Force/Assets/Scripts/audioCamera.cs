using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioCamera : MonoBehaviour
{
    public AudioSource cameraSound;
   
    // Start is called before the first frame update
    void Start()
    {
        cameraSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
