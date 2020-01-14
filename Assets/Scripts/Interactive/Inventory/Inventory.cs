using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject Key;
    public GameObject RecipeScrap1;
    public GameObject RecipeScrap2;
    public GameObject RecipeScrap3;
    //public GameObject BusiessCard;
    //public GameObject Key;
    //public GameObject Dna;
    //public GameObject Hand;

    // Update is called once per frame
    void Update()
    {
        int var1 = PlayerPrefs.GetInt("Key");
        if(var1 == 1)
        {
            Key.SetActive(true);
        }
        else
        {
            Key.SetActive(false);
        }
        int var2 = PlayerPrefs.GetInt("Recipe Scrap 1");
        if (var2 == 1)
        {
            RecipeScrap1.SetActive(true);
        }
        else
        {
            RecipeScrap1.SetActive(false);
        }
        int var3 = PlayerPrefs.GetInt("Recipe Scrap 2");
        if (var3 == 1)
        {
            RecipeScrap2.SetActive(true);
        }
        else
        {
            RecipeScrap2.SetActive(false);
        }
        int var4 = PlayerPrefs.GetInt("Recipe Scrap 3");
        if (var4 == 1)
        {
            Debug.Log(var4);
            RecipeScrap3.SetActive(true);
        }
        else
        {
            Debug.Log(var4);
            RecipeScrap3.SetActive(false);
        }
        //int var5 = PlayerPrefs.GetInt("SkidMarker3");
        //if (var5 == 1)
        //{
        //    Skid3.SetActive(true);
        //}
        //else
        //{
        //    Skid3.SetActive(false);
        //}
        //int var6 = PlayerPrefs.GetInt("PhotoFolder");
        //if (var6 == 1)
        //{
        //    Key.SetActive(true);
        //}
        //else
        //{
        //    Key.SetActive(false);
        //}
        //int var7 = PlayerPrefs.GetInt("DNASample");
        //if (var7 == 1)
        //{
        //    Dna.SetActive(true);
        //}
        //else
        //{
        //    Dna.SetActive(false);
        //}
        //int var8 = PlayerPrefs.GetInt("Hand");
        //if (var8 == 1)
        //{
        //    Hand.SetActive(true);
        //}
        //else
        //{
        //    Hand.SetActive(false);
        //}
    }

    //public void ResetItem()
    //{
    //    PlayerPrefs.SetInt("Microfiche",0);
    //    PlayerPrefs.SetInt("BusinessCard", 0);
    //    PlayerPrefs.SetInt("SkidMarker1", 0);
    //    PlayerPrefs.SetInt("SkidMarker2", 0);
    //    PlayerPrefs.SetInt("SkidMarker3", 0);
    //    PlayerPrefs.SetInt("PhotoFolder", 0);
    //    PlayerPrefs.SetInt("DNASample", 0);
    //    PlayerPrefs.SetInt("Hand", 0);
    //}
}
