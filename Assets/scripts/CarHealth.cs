using UnityEngine;
using Photon.Pun;

public class CarHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Car hit! Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            PhotonView pv = GetComponent<PhotonView>();
            pv.RPC("DestroyCar", RpcTarget.All);
        }
    }

    [PunRPC]
    void DestroyCar()
    {
        //PhotonView pv = GetComponent<PhotonView>();
        //DestroyCar(pv.gameObject);
        //Destroy(gameObject);
        if (GetComponent<PhotonView>().IsMine)
        {
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                Destroy(renderer.gameObject);
                renderer.enabled = false;

            }

            Collider collider = GetComponent<Collider>();
            if (collider != null)
            {
                collider.enabled = false;
            }
        }


    }
}




//using UnityEngine;

//public class CarHealth : MonoBehaviour
//{
//    public int maxHealth = 5;
//    public int currentHealth;

//    // Start is called before the first frame update
//    void Start()
//    {
//        currentHealth = maxHealth;
//    }

//    public void TakeDamage(int damage)
//    {
//        currentHealth -= damage;
//        Debug.Log("Car hit! Health: " + currentHealth);

//        if (currentHealth <= 0)
//        {
//            Destroy(gameObject);
//        }
//    }
//}
