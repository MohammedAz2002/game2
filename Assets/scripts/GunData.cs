using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GunData : MonoBehaviour //ScriptableObject
{
    //public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 160f;

    public float timeBetweenShots = 0.1f;

    private float timeSinceLastShot = 0f;
    PhotonView view;
    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && timeSinceLastShot >= timeBetweenShots)
        {
            Shoot();
            timeSinceLastShot = 0f;
        }
    }

    void Shoot()
    {
        if (view.IsMine)
        {
            GameObject bulletPrefab = GameObject.Find("bullet");
            // Instantiate a new bullet at the fire point position and rotation
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            // Get the Rigidbody component of the bullet
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

            // Add force to the bullet in the forward direction of the fire point
            bulletRigidbody.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);

            Destroy(bullet, 0.8f);
        }
    }

    //[Header("Info")]
    //public new string name;

    //[Header("shooting")]
    //public float damage;
    //public float maxDistance;

    //[Header("Reloading")]
    //public int currentAmmo;
    //public int magSize;
    //public float fireRate;
    //public float reloadTime;
    //public bool reloading;

}
