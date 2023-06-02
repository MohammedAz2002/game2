using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject smoke;
    private GameObject explosion;
    private GameObject smoke1;

    private void OnCollisionEnter(Collision collision)
    {

        explosion=Instantiate(explosionPrefab, collision.GetContact(0).point, Quaternion.identity);
        smoke1 = Instantiate(smoke, collision.GetContact(0).point, Quaternion.identity);
        if (gameObject != null)
        {
            Destroy(gameObject);
        }
        Destroy(explosion,1f);
        Destroy(smoke1, 3f);

    }
}



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FallingObject : MonoBehaviour
//{
//    public GameObject objectPrefab;
//    public GameObject sphereObject;
//    public float sphereRadius = 10f;

//    private GameObject currentObject;

//    private void Start()
//    {
//        StartCoroutine(RespawnObject());
//    }

//    private System.Collections.IEnumerator RespawnObject()
//    {
//        while (true)
//        {


//            yield return new WaitForSeconds(2f);
//            Vector3 spawnPosition = Random.onUnitSphere * sphereRadius/0.5f;
//            currentObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
//            Destroy(currentObject, 2.6f);
//            // You can perform any additional setup or modifications on the currentObject here
//        }
//    }
//    private void OnCollisionEnter(Collision collision)
//    {
//        GameObject otherObject = collision.gameObject;
//        FallingObject fallingObject = otherObject.GetComponent<FallingObject>();
//        if (fallingObject != null)
//        {
//            Destroy(fallingObject.gameObject);
//        }
//    }

//}
