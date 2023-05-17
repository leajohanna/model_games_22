using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMouse : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    
    void Update()
    {
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
    }
}
