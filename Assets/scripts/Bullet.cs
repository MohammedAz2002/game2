using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion1;
    private GameObject explosion;


    private void OnCollisionEnter(Collision collision)
    {

        explosion = Instantiate(explosion1, transform.position, Quaternion.identity);



        // Destroy the explosion after 1 second
        Destroy(explosion, 1f);


    }
    
}
