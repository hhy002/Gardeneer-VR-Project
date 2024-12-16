using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizedBirdSounds : MonoBehaviour
{
    public AudioClip[] allBirdSounds;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 200) == 3) {
            source.clip = allBirdSounds[Random.Range(0, allBirdSounds.Length)];
            source.PlayOneShot(source.clip);
        }
    }
}
