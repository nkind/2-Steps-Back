using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skid3Check : MonoBehaviour
{
    public GameObject cover;

    // Update is called once per frame
    void Update()
    {
        int var = PlayerPrefs.GetInt("SkidMarker3");
        if (var == 1)
        {
            cover.SetActive(true);
        }
        else
        {
            cover.SetActive(false);
        }
    }
}
