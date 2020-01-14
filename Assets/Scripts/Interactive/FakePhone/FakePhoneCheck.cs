using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePhoneCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dnabutton;
    public GameObject Chemicalbutton;

    void Start()
    {
        //condition to dna puzzle
        int var1 = PlayerPrefs.GetInt("DNASample");
        if (var1 == 1)
        {
            Dnabutton.SetActive(true);
        }
        else
        {
            Dnabutton.SetActive(false);
        }
        //condition to chemical puzzle
        int var2 = PlayerPrefs.GetInt("Recipe Scrap 3");
        int var3 = PlayerPrefs.GetInt("Recipe Scrap 3");
        int var4 = PlayerPrefs.GetInt("Recipe Scrap 3");
        if (var2 == 1 && var3 == 1 && var4 == 1)
        {
            Chemicalbutton.SetActive(true);
        }
        else
        {
            Chemicalbutton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
