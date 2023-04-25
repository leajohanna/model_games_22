using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_die : MonoBehaviour
{
    public float threshhold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if(transform.posision.y < threshhold)
    }
}
