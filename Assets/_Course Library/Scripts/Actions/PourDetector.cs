using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public ParticleSystem water;

    private bool isPouring = false;

    private void Start() {
        gameObject.GetComponent<ParticleSystem>().Stop();
    }
    private void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;

        if(isPouring != pourCheck)
        {
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

    private void StartPour()
    {

    }

    private void EndPour()
    {

    }

    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

}
