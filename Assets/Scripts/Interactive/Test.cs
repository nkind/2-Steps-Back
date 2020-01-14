using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    public Camera camera;
    // Use this for initialization
    void Start()
    {
        camera.orthographicSize = 5; // Size u want to start with
    }

    // Update is called once per frame
    void Update()
    {
        if (Goback.backZoom == "y")
        {
            
            camera.orthographicSize = camera.orthographicSize + 3 * Time.deltaTime;
            if (camera.orthographicSize > 5)
            {
                camera.orthographicSize = 5; // Max size
            }
        }


        if (InteractiveObject.zoomActive == "y") 
        {
            
            camera.orthographicSize = camera.orthographicSize - 3 * Time.deltaTime;
            if (camera.orthographicSize < 2f)
            {
                camera.orthographicSize = 2f; // Min size 
            }

        }
    }
}
