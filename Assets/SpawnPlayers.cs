using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public float minx;
    public float miny;
    public float maxx;
    public float maxy;
    public float minz;
    public float maxz;

    private void Start()
    {
        Vector3 randomPosition = new Vector3(minx, miny,minz);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition,Quaternion.identity);
    }
}
