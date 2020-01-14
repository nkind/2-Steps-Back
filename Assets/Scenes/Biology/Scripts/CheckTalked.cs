using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTalked : MonoBehaviour
{
    public GameObject foreman;
    public GameObject directionUnlocked;
    void Awake()
    {
        int var = PlayerPrefs.GetInt("ForeManDoor");
        if(var == 1)
        {
            foreman.SetActive(false);
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            directionUnlocked.SetActive(true);

        }
    }

    
}
