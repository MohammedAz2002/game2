using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitybody : MonoBehaviour
{
    public gravity attractor;
    // Start is called before the first frame update
    private Transform myTransform;

    void Start()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform);
    }
}
