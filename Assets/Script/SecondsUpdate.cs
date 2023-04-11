using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float timeStartOffset = 0;
    public float speed = 0.5f;
    bool gotStartTime = false;

    void Update()
    {
        if (!gotStartTime)
        {
            timeStartOffset = Time.realtimeSinceStartup;
            gotStartTime = true;    
        }

        transform.position = new Vector3(transform.position.x,transform.position.y, speed * (Time.realtimeSinceStartup - timeStartOffset));   
    }
}
