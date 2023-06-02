using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarFallingObject : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;
        FallingObject fallingObject = otherObject.GetComponent<FallingObject>();
        if (fallingObject != null)
        {
            CarHealth targetHealth = GetComponent<CarHealth>();
            Destroy(fallingObject.gameObject);
            targetHealth.TakeDamage(5);
        }
    }
       

}
