using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    // Angle of pour
    public int pourThreshold = 45;
    public Transform origin = null;
    public ParticleSystem water;

    private bool isPouring = false;

    private void Start() {
        // Stop at first (doesn't work sadly)
        gameObject.GetComponent<ParticleSystem>().Stop();
    }
    private void Update()
    {
        // Find if the current pour angle is less than threshold
        bool pourCheck = CalculatePourAngle() < pourThreshold;

        if(isPouring != pourCheck)
        {
            // If yes, pour, if no then don't
            isPouring = pourCheck;
            if(isPouring)
            {
                gameObject.GetComponent<ParticleSystem>().Play();
            }
            else
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
            }
        }
    }
    // Getter function to get angle
    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

}
