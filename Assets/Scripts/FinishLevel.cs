using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public GameObject finish;
    public GameObject player1;
    public GameObject player2;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            finish.SetActive(true);
            player1.SetActive(false);
            player2.SetActive(false);
            DestroyObject();
            
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
