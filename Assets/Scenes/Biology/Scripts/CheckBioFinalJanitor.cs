using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBioFinalJanitor : MonoBehaviour
{
    public GameObject foreman;
    public GameObject directionUnlocked;
    
    void Awake()
    {
        int var = PlayerPrefs.GetInt("bioJanitor");
        if (var == 1)
        {
            foreman.SetActive(false);
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            directionUnlocked.SetActive(true);
            

        }
        
    }
    private void Update()
    {
        
    }
}
