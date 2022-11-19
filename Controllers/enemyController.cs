using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed;
    public Vector3 position1;
    public Vector3 position2;
    public float direction=1; 
    
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed*direction, 0, 0);
        if(transform.position.x >position1.x){
            direction = -1;
        }
        if(transform.position.x <position2.x){
            direction = 1;
        }
    }
}
