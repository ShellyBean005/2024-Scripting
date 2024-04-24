using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
    private bool hasPowerup;
    public GameObject powerupIndicator;
    public GameObject projectile;
    public GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
        float maxDistance = projectile.GetComponent<Projectile>().maxDistance;
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            PlayerTakeDamage(10);
            Debug.Log(gameManager._gameManager._playerHealth.health);
        }

        if(hasPowerup)
        {
            projectile.GetComponent<Projectile>().maxDistance = 30.0f;
            firePoint.GetComponent<PlayerShooter>().firingSpeed = 0.05f;
          
        }

        else
        {
            projectile.GetComponent<Projectile>().maxDistance = 15.0f;
            firePoint.GetComponent<PlayerShooter>().firingSpeed = 0.2f;
        }
    }

    private void PlayerTakeDamage(int damage)
    {
        gameManager._gameManager._playerHealth.Damage(damage);
    }

    private void PlayerTakeHeal(int heal) 
    {
        gameManager._gameManager._playerHealth.Heal(heal);
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdown());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountdown()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    
}
