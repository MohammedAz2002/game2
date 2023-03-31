using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public float gravity1 = -500;

    public void Attract(Transform body)
    {
        Vector3 gravityUp=(body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.GetComponent<Rigidbody>().AddForce(gravityUp*gravity1);
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp,gravityUp)*body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50*Time.deltaTime);
    }
}
