using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunData : MonoBehaviour //ScriptableObject
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 100f;

    public float timeBetweenShots = 0.1f;

    private float timeSinceLastShot = 0f;

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
        // Instantiate a new bullet at the fire point position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the bullet
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // Add force to the bullet in the forward direction of the fire point
        bulletRigidbody.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
    
        Destroy(bullet, 1f);
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
