using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 firingPoint;
    public float projectileSpeed;
    public float xBounds;
    public float zBounds;
    public float maxDistance;
    // Start is called before the first frame update
    void Start()
    {
        firingPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveProjectile();
        outOfBounds();
    }

    void moveProjectile()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        if(Vector3.Distance(firingPoint, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void outOfBounds()
    {
        if (transform.position.x < -xBounds || transform.position.x > xBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -zBounds || transform.position.z > zBounds)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter (Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
    

}
