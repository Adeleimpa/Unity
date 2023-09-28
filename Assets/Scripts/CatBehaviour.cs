using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    public AudioSource collisionSound;
    public GameObject fx;

    public GameObject worldObject;

    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
    }
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(fx, transform.position, Quaternion.identity);

            if (collisionSound)
            {
                collisionSound.Play();
            }

            Destroy(gameObject);
            worldObject.SendMessage("AddHit");

        }
    }
}
