using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject sphereObject;

    private void Start()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        // Generate a random point within the spherical world
        Vector3 randomPoint = Random.onUnitSphere * sphereObject.transform.localScale.x / 2.0656f;
        Vector3 randomPosition = sphereObject.transform.position + randomPoint;

        // Spawn the player at the random position
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);

        // Move the player downwards until it rests on the surface of the sphere
        Vector3 playerPosition = player.transform.position;
        RaycastHit hit;
        if (Physics.Raycast(playerPosition, -player.transform.up, out hit))
        {
            playerPosition = hit.point;
        }
        player.transform.position = playerPosition;
    }

}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Photon.Pun;

//public class SpawnPlayers : MonoBehaviour
//{
//    public GameObject playerPrefab;

//    public float minx;
//    public float miny;
//    public float maxx;
//    public float maxy;
//    public float minz;
//    public float maxz;

//    private void Start()
//    {
//        Vector3 randomPosition = new Vector3(minx, miny,minz);
//        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition,Quaternion.identity);
//    }
//}
