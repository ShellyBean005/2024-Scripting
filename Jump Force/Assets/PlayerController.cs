using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //RB and Jump
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    //GameOver
    public bool gameOver = false;

    //animation
    private Animator playerAnim;
    public ParticleSystem explosionParticle;

    //sound 
    public ParticleSystem dirtParticle;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    public AudioClip jumpSound;


    // Start is called before the first frame update
    void Start()
    {
        //get RB
        playerRb = GetComponent<Rigidbody>();
        //get Animation
        playerAnim = GetComponent<Animator>();
        //set gravity
        Physics.gravity *= gravityModifier;
        //get audio
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //dirt particle while running
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            //animation
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            //particle change
            explosionParticle.Play();
            dirtParticle.Stop();
            //audio crash
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
