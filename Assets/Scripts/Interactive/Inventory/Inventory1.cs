using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory1 : MonoBehaviour
{
    public GameObject MicroFiche;
    public GameObject Skid1;
    public GameObject Skid2;
    public GameObject Skid3;
    public GameObject BusiessCard;
    public GameObject Key;
    public GameObject Dna;
    public GameObject Hand;

    // Update is called once per frame
    void Update()
    {
        int var1 = PlayerPrefs.GetInt("Microfiche");
        if (var1 == 1)
        {
            MicroFiche.SetActive(true);
        }
        else
        {
            MicroFiche.SetActive(false);
        }
        int var2 = PlayerPrefs.GetInt("BusinessCard");
        if (var2 == 1)
        {
            BusiessCard.SetActive(true);
        }
        else
        {
            BusiessCard.SetActive(false);
        }
        int var3 = PlayerPrefs.GetInt("SkidMarker1");
        if (var3 == 1)
        {
            Skid1.SetActive(true);
        }
        else
        {
            Skid1.SetActive(false);
        }
        int var4 = PlayerPrefs.GetInt("SkidMarker2");
        if (var4 == 1)
        {
            Skid2.SetActive(true);
        }
        else
        {
            Skid2.SetActive(false);
        }
        int var5 = PlayerPrefs.GetInt("SkidMarker3");
        if (var5 == 1)
        {
            Skid3.SetActive(true);
        }
        else
        {
            Skid3.SetActive(false);
        }
        int var6 = PlayerPrefs.GetInt("PhotoFolder");
        if (var6 == 1)
        {
            Key.SetActive(true);
        }
        else
        {
            Key.SetActive(false);
        }
        int var7 = PlayerPrefs.GetInt("DNASample");
        if (var7 == 1)
        {
            Dna.SetActive(true);
        }
        else
        {
            Dna.SetActive(false);
        }
        int var8 = PlayerPrefs.GetInt("Hand");
        if (var8 == 1)
        {
            Hand.SetActive(true);
        }
        else
        {
            Hand.SetActive(false);
        }
    }

    public void ResetItem()
    {
        PlayerPrefs.SetInt("Microfiche", 0);
        PlayerPrefs.SetInt("BusinessCard", 0);
        PlayerPrefs.SetInt("SkidMarker1", 0);
        PlayerPrefs.SetInt("SkidMarker2", 0);
        PlayerPrefs.SetInt("SkidMarker3", 0);
        PlayerPrefs.SetInt("PhotoFolder", 0);
        PlayerPrefs.SetInt("DNASample", 0);
        PlayerPrefs.SetInt("Hand", 0);
    }
}
