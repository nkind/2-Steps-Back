using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDrImpa : MonoBehaviour
{
    public GameObject DrImpa;
    // Start is called before the first frame update
    void Start()
    {
        int var = PlayerPrefs.GetInt("DrImpa");

        if(var == 1)
        {
            DrImpa.SetActive(false);
        }
    }

   
}
