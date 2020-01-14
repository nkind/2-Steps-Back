using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChemLabLeft : MonoBehaviour
{
    public GameObject body1;
    public GameObject body2;
    public GameObject body1Text;
    public GameObject body2Text;
    public GameObject hazardBin;
    public GameObject BinText;
    public GameObject Win;
    public GameObject dnaSample;

    public GameObject Beaker;
    public GameObject BeakerTrigger;

    public GameObject hint1;
    public GameObject hint2;

    public GameObject DnaPass;
    public GameObject ChemicalPass;
    public GameObject BeakerPass;

    public void Body1ToLab()
    {
        body1.SetActive(false);
    }
    public void LabToBody1()
    {
        body1.SetActive(true);
        body2.SetActive(false);
        //body1Text.SetActive(true);
    }
    public void ClickDisappear()
    {
        body1Text.SetActive(false);
    }
    public void Body1To2()
    {
        body2.SetActive(true);
        //body1Text.SetActive(true);
    }
    public void Body2To1()
    {
        body2.SetActive(false);
        //body1Text.SetActive(true);
    }
    public void Body2ClickText()
    {
        body2Text.SetActive(false);
    }
    public void HazardBin()
    {
        hazardBin.SetActive(true);
    }
    public void ClickHazardDisappear()
    {
        BinText.SetActive(false);
    }
    public void HazardBinGone()
    {
        hazardBin.SetActive(false);
    }
    public void ClickBeaker()
    {
        Beaker.SetActive(true);
    }
    public void WaitBeaker()
    {
        Beaker.SetActive(false);
    }
    public void seeDnaResult()
    {
        PlayerPrefs.SetInt("DnaResultSaw",1);
    }
    public void seeChemResult()
    {
        PlayerPrefs.SetInt("ChemResult", 1);
    }
    void Start()
    {
        int var = PlayerPrefs.GetInt("BeakerWin");
        int vare = PlayerPrefs.GetInt("BeakerRead");
        if(var == 1 && vare != 1)
        {
            BeakerPass.SetActive(true);
        }
        else
        {
            BeakerPass.SetActive(false);
        }
        //int var1 = PlayerPrefs.GetInt("BeakerPuzzleRead");
        //if (var == 1 && var1 == 1)
        //{
        //    BeakerTrigger.SetActive(false);
        //    GameObject varObject = GameObject.Find("Main Camera");
        //    varObject.GetComponent<TriggerWhenStart>().enabled = true;
            
        //}
        int var2 = PlayerPrefs.GetInt("DebraChem");
        if(var2 != 1)
        {
            BeakerTrigger.SetActive(false);
        }
        if(var == 1)
        {
            BeakerTrigger.SetActive(false);
            
        }

        //int var3 = PlayerPrefs.GetInt("ChemPass");
        //int vara = PlayerPrefs.GetInt("ChemResult");
        //if (var3 == 1 && vara != 1)
        //{
        //   // ChemicalPass.SetActive(true);

        //}
        //else
        //{
        //    ChemicalPass.SetActive(false);
        //}
        //int var4 = PlayerPrefs.GetInt("DNAPass");
        //int varb = PlayerPrefs.GetInt("DnaResultSaw");
        //if (var4 == 1 && varb != 1)
        //{
        //    //DnaPass.SetActive(true);

        //}
        //else
        //{
        //    DnaPass.SetActive(false);
        //}
        CheckAllPass();
    }
    private void Update()
    {
        int var1 = PlayerPrefs.GetInt("DNASample");
        if (var1 == 1)
        {
            dnaSample.SetActive(false);
        }
        int var3 = PlayerPrefs.GetInt("Recipe Scrap 1");
        if (var3 != 1)
        {
            hint1.SetActive(true);
        }
        if (var3 == 1)
        {
            hint1.SetActive(false);

        }
        int var4 = PlayerPrefs.GetInt("Recipe Scrap 2");
        if (var4 != 1)
        {
            hint2.SetActive(true);
        }
        if (var4 == 1)
        {
            hint2.SetActive(false);

        }

        //Map Marker
        if(PlayerPrefs.GetInt("BeakerWin") == 1 && PlayerPrefs.GetInt("DNAPass")==1)
        {
            //Geo is Bio. Sorry for confusing, its easier to not change it now tho
            PlayerPrefs.SetInt("Geo", 1);
        }
    }

    void CheckAllPass()
    {
       
        int var1 = PlayerPrefs.GetInt("BeakerWin");
        int var2 = PlayerPrefs.GetInt("ChemPass");
        int var3 = PlayerPrefs.GetInt("DNAPass");
        if (var1 == 1 && var2 == 1 && var3 ==1)
        {
            Win.SetActive(true);
        }
      
    }
}
