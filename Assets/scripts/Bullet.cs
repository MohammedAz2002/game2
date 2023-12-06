using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion1;
    private GameObject explosion;


    private void OnCollisionEnter(Collision collision)
    {

        Invoke("InstantiateExplosion", 0.2f);


    }
    private void InstantiateExplosion()
    {
        explosion = Instantiate(explosion1, transform.position, Quaternion.identity);

        // Destroy the gameObject after 1 second
        if (gameObject != null)
        {
            Destroy(gameObject, 1f);
        }

        // Destroy the explosion after 1 second
        Destroy(explosion, 1f);
    }
}
