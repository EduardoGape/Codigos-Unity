using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject shoot;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = PlayerController.PlayerPosition;
    }

    public void Shoot(){
        Instantiate(shoot, position, Quaternion.identity);
    }
}
