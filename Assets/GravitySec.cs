using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySec : MonoBehaviour
{
    //public gravity attractor;

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
        float carXPosition = transform.position.z;
        gravity attractor;
        //attractor = GameObject.Find("Sphere").GetComponent<gravity>();
        if (carXPosition <= -6.45 && carXPosition >= -7.5)
        {
            // attract sphere1
            attractor = GameObject.Find("Sphere3").GetComponent<gravity>();
        }
        //else if (carXPosition <= -7 && carXPosition >= -8)
        //{
        //    // attract sphere1
        //    attractor = GameObject.Find("Sphere20").GetComponent<gravity>();
        //}
        else if (carXPosition <= -7.5 && carXPosition >= -8.5)
        {
            // attract sphere1
            attractor = GameObject.Find("Sphere21").GetComponent<gravity>();
        }
        else if (carXPosition <= -8.5 && carXPosition >= -9)
        {
            // attract sphere1
            attractor = GameObject.Find("Sphere22").GetComponent<gravity>();
        }
        else if (carXPosition <= -9 && carXPosition >= -9.3)
        {
            // attract sphere1
            attractor = GameObject.Find("Sphere23").GetComponent<gravity>();
        }
        else if (carXPosition <= -9.3)
        {
            // attract sphere1
            attractor = GameObject.Find("Sphere2").GetComponent<gravity>();
        }
        else if (carXPosition <= -6.25 && carXPosition >= -6.45)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere4").GetComponent<gravity>();
        }
        else if (carXPosition <= -6.05 && carXPosition >= -6.25)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere5").GetComponent<gravity>();
        }
        else if (carXPosition <= -5.85 && carXPosition >= -6.05)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere6").GetComponent<gravity>();
        }
        else if (carXPosition <= -5.65 && carXPosition >= -5.85)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere7").GetComponent<gravity>();
        }
        else if (carXPosition <= -5.45 && carXPosition >= -5.65)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere8").GetComponent<gravity>();
        }
        else if (carXPosition <= -5.25 && carXPosition >= -5.45)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere9").GetComponent<gravity>();
        }
        else if (carXPosition <= -5.05 && carXPosition >= -5.25)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere10").GetComponent<gravity>();
        }
        else if (carXPosition <= -4.85 && carXPosition >= -5.05)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere11").GetComponent<gravity>();
        }
        else if (carXPosition <= -4.65 && carXPosition >= -4.85)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere12").GetComponent<gravity>();
        }
        else if (carXPosition <= -4.45 && carXPosition >= -4.65)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere13").GetComponent<gravity>();
        }
        else if (carXPosition <= -4.25 && carXPosition >= -4.45)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere14").GetComponent<gravity>();
        }
        else if (carXPosition <= -4.05 && carXPosition >= -4.25)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere15").GetComponent<gravity>();
        }
        else if (carXPosition <= -3.85 && carXPosition >= -4.05)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere16").GetComponent<gravity>();
        }
        else if (carXPosition <= -3.65 && carXPosition >= -3.85)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere17").GetComponent<gravity>();
        }
        else if (carXPosition <= -3.4 && carXPosition >= -3.65)
        {
            // attract sphere2
            attractor = GameObject.Find("Sphere19").GetComponent<gravity>();
        }
        else if (carXPosition >= -3.4 && carXPosition <= -3.6)
        {
            attractor = GameObject.Find("Sphere24").GetComponent<gravity>();
        }
        else
        {
            attractor = GameObject.Find("Sphere1").GetComponent<gravity>();
        }
        attractor.Attract(myTransform);
    }
}
