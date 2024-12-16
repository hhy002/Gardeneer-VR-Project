using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    // Start is called before the first frame update
    private int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;
    void Start()
    {
        InvokeRepeating("Growth", timeBetweenGrowths, timeBetweenGrowths);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Growth() {
        // Don't stop until reach max stage growth
        if(currentProgression != maxGrowth) {
            gameObject.transform.GetChild(currentProgression).gameObject.SetActive(true);
            }
        // Turn off previous progression
        if(currentProgression > 0 && currentProgression < maxGrowth) {
            gameObject.transform.GetChild(currentProgression - 1).gameObject.SetActive(false);
        }
        
        if(currentProgression < maxGrowth) {
            currentProgression++;
        }
    }
}
