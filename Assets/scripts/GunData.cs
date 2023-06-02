using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GunData : MonoBehaviourPunCallbacks
{
    public Transform firePoint;
    public float bulletForce = 160f;
    public GameObject fire;
    public float timeBetweenShots = 0.1f;

    private float timeSinceLastShot = 0f;
    private GameObject fireExplosion;

    private void Update()
    {
        if (!photonView.IsMine)
            return;

        timeSinceLastShot += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && timeSinceLastShot >= timeBetweenShots)
        {
            photonView.RPC("Shoot", RpcTarget.All);
            timeSinceLastShot = 0f;
        }
    }

    [PunRPC]
    void Shoot()
    {
        fireExplosion = Instantiate(fire, firePoint.position, Quaternion.identity);

        // Instantiate a new bullet prefab locally on the shooting player's client
        GameObject bulletPrefab = Instantiate(Resources.Load("bullet") as GameObject, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the bullet
        Rigidbody bulletRigidbody = bulletPrefab.GetComponent<Rigidbody>();

        // Add force to the bullet in the forward direction of the fire point
        bulletRigidbody.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);

        Destroy(bulletPrefab, 0.8f);
        Destroy(fireExplosion, 0.6f);
    }
}

