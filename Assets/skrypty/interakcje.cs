using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interakcje : MonoBehaviour
{
    //detection Point
    public Transform detectionPoint;
    //detection Radius
    public const float detectionRadius= 0.2f;
    //detection Layer
    public LayerMask detectionLayer;

    // Update is called once per frame
    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                Debug.Log("Interact");
            }
        }
    }
    bool InteractInput()
    {
       return Input.GetKeyDown(KeyCode.E);
    }

   bool DetectObject()
    {
        bool isDetected = Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer);
        return isDetected;
    }
}
