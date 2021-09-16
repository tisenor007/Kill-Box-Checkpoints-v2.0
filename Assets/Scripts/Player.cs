using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "KillBox")
        {
            transform.position = spawnPoint;
        }

        if (other.gameObject.tag == "CheckPoint")
        {
            spawnPoint = other.gameObject.transform.position;
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LavaPit")
        {
            transform.position = spawnPoint;
        }
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
            spawnPoint = transform.position;
        }
    }
}
