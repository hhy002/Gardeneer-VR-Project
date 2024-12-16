using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Tilling : MonoBehaviour
{
    public AudioSource source;

    public GameObject tillageArea;

   void OnCollisionEnter(Collision collisionInfo) {
        source = GetComponent<AudioSource>();

        if(collisionInfo.collider.tag == "Tool") {
            Instantiate(tillageArea, transform.position, Quaternion.identity);
            source.Play();
        }
        
    }

}
