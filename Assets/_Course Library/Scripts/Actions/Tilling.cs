using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Tilling : MonoBehaviour
{
    public AudioSource source;

    public GameObject tillageArea;

    // When ground and tool collide
   void OnCollisionEnter(Collision collisionInfo) {
        source = GetComponent<AudioSource>();

        // Has to be tagged as a tool
        if(collisionInfo.collider.tag == "Tool") {
            // Create tilling area at that place
            Instantiate(tillageArea, transform.position, Quaternion.identity);
            source.Play();
        }
        
    }

}
