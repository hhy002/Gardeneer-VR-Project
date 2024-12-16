using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
int _rotationSpeed = 15;

void Update () {

    // Rotation on y axis
    // be sure to capitalize Rotate or you'll get errors
    transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
}
}
