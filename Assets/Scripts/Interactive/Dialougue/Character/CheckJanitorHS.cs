using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJanitorHS : MonoBehaviour
{
    public GameObject JanitorHS;
    // Start is called before the first frame update
    void Start()
    {
        int var = PlayerPrefs.GetInt("JanitorHS");

        if (var == 1)
        {
            JanitorHS.SetActive(false);
        }
    }

   
}
