using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
   
    public Transform firingPoint;

    public GameObject projectilePrefab;
    public float firingSpeed;
    private float lastTimeShot = 0;

    public static PlayerShooter Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = GetComponent<PlayerShooter>();
    }


    public void shoot()
    {
        if (lastTimeShot + firingSpeed <= Time.time)
        {
            lastTimeShot = Time.time;
            Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
        }
    }
}
