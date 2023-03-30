using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carBullet : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    //public GameObject carGameObject; // Reference to the GameObject that represents the car

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;
        Bullet bullet = otherObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            CarHealth targetHealth = GetComponent<CarHealth>();
            Destroy(bullet.gameObject);
            targetHealth.TakeDamage(1);

            
        }
    }



}
