using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at : MonoBehaviour
{
    public Transform look_at_object;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(look_at_object);
    }
}
