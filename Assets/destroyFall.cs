using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFall : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject sphereObject;
    public float sphereRadius = 10f;
    private int c = 0;

    private GameObject currentObject;

    private void Start()
    {
        StartCoroutine(RespawnObject());
    }

    private System.Collections.IEnumerator RespawnObject()
    {
        while (true)
        {

            if (c < 30)
            {


                yield return new WaitForSeconds(1f);
                Vector3 spawnPosition = Random.onUnitSphere * sphereRadius / 0.5f;
                currentObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
                //Destroy(currentObject, 2.6f);
                // You can perform any additional setup or modifications on the currentObject here
            }
        }
    }

}
