using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSCheckInventory : MonoBehaviour
{
    public GameObject microfin;
    public GameObject businesscard;

    // Update is called once per frame
    void Update()
    {
        int var1 = PlayerPrefs.GetInt("Microfiche");
        if (var1 != 1)
        {
            microfin.SetActive(true);
        }
        else
        {
            microfin.SetActive(false);
        }
        int var2 = PlayerPrefs.GetInt("BusinessCard");
        if (var2 != 1)
        {
            businesscard.SetActive(true);
        }
        else
        {
            businesscard.SetActive(false);
        }
    }
}
