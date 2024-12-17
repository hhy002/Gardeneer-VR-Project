using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    // Start is called before the first frame update
    private int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;
    public ParticleSystem wateringCan;
    private float mustWaterTimer;
    public float mustWaterDefault;
    void Start()
    {
        mustWaterTimer = mustWaterDefault;
        InvokeRepeating("Growth", timeBetweenGrowths, timeBetweenGrowths);
    }

    // Update is called once per frame
    void Update()
    {
        // Constantly counting down time til plant dies
        mustWaterTimer -= Time.deltaTime;
        if (mustWaterTimer < 0) {
            // Plant dies
            PlantDie();
        }
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
    public void PlantDie() {
        for(int i = 0; i < transform.childCount; i++) {
            //deavtivate all children
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        // Set dead as true
        gameObject.transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
    }

    // Watering plant to stay alive
    public void OnTriggerStay(Collider other) {
        if(other.CompareTag("Water")) {
            mustWaterTimer = mustWaterDefault;
        }
    }

}
