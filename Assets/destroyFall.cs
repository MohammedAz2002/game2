using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;
        FallingObject fallingObject = otherObject.GetComponent<FallingObject>();
        if (fallingObject != null)
        {
            Destroy(fallingObject.gameObject);
        }
    }
}
