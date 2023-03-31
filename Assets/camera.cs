using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class camera : MonoBehaviour
{
    public int objectToTrackID; // The PhotonView ID of the game object that the camera should track
    public float followDistance = 10f; // The distance between the camera and the tracked object
    public float followHeight = 3f; // The height offset between the camera and the tracked object

    private PhotonView objectToTrack; // The PhotonView component attached to the game object we're tracking

    void Start()
    {
        // Get the PhotonView component with the specified ID
        objectToTrack = PhotonView.Find(objectToTrackID);
    }

    void LateUpdate()
    {
        if (objectToTrack != null && objectToTrack.IsMine)
        {
            // Make the camera always point towards the object to track
            transform.LookAt(objectToTrack.transform);

            // Move the camera to a position behind and above the object to track
            transform.position = objectToTrack.transform.position - objectToTrack.transform.forward * followDistance + objectToTrack.transform.up * followHeight;
        }
    }
}


