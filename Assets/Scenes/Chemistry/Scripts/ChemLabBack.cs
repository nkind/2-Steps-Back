using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemLabBack : MonoBehaviour
{
    public GameObject key;
    public GameObject drawer;
    public GameObject clue;
    void Start()
    {
        int var = PlayerPrefs.GetInt("ChemDKey");
        if(var == 1)
        {
            key.SetActive(false);
        }
    }

    public void Key()
    {
        PlayerPrefs.SetInt("ChemDKey", 1);
        key.SetActive(false);
    }
    public void DrawerOpen()
    {
        drawer.SetActive(true);
    }
    public void DrawerClose()
    {
        drawer.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
        int var2 = PlayerPrefs.GetInt("Key");
        if (var2 == 1)
        {
            key.SetActive(false);
        }
        else
        {
            key.SetActive(true);
        }
        int var1 = PlayerPrefs.GetInt("Recipe Scrap 3");
        if (var1 == 1)
        {
            clue.SetActive(false);
        }
        else
        {
            clue.SetActive(true);
        }
    }
}
