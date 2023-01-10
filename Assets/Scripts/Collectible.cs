using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public bool inInventory = false;
    public GameObject santaCar;
    public GameObject deathSantaCar;
    public GameObject death;

    private void Start()
    {
        death.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Gremlin"))
        {
            Destroy(collision.gameObject);
            inInventory = true;
            santaCar.SetActive(false);
            deathSantaCar.SetActive(true);
            death.SetActive(true);
        }

        if (collision.collider.CompareTag("Mülleimer"))
        {
            inInventory = false;
            santaCar.SetActive(true);
            deathSantaCar.SetActive(false);
        }
    }
}