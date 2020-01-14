using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(InteractiveObject.zoomActive == "y")
        {
            GetComponent<Camera>().enabled = true;
        }
    }
}
