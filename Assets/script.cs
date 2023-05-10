using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToSphere : MonoBehaviour
{
    public Transform sphereTransform;
    public float sphereRadius;

    private void LateUpdate()
    {
        Vector3 direction = transform.position - sphereTransform.position;
        float distance = direction.magnitude;
        if (distance > sphereRadius)
        {
            transform.position = sphereTransform.position + direction.normalized * sphereRadius;
        }
    }
}
