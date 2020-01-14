using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemLabStart : MonoBehaviour
{
    public GameObject Debra;
    void Awake()
    {
        int var = PlayerPrefs.GetInt("DebraChem");
        if(var == 1)
        {
            Debra.SetActive(false);
        }
    }

}
