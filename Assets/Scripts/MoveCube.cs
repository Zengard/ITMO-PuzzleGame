using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public GameObject player;
    Vector3 scale;
    private void Start()
    {
        scale = player.transform.localScale;
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.localScale = scale;
            other.transform.SetParent(transform);
        }    
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.localScale = scale;
            other.transform.SetParent(null);
        }
            
    }
}
