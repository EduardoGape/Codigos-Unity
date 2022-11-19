using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float speed;
    public float direction=1; 
    
    void Update()
    {
        transform.position = transform.position + new Vector3(speed*direction, 0, 0);
    }

}
