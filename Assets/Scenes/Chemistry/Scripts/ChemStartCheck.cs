using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemStartCheck : MonoBehaviour
{
    public GameObject direction;
    
    // Start is called before the first frame update
    void Awake()
    {
        int var = PlayerPrefs.GetInt("ChemStart");
        if(var == 1)
        {
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            direction.SetActive(true);
        }
        
    }
    public void Reset()
    {
        PlayerPrefs.SetInt("ChemStart", 0);
        PlayerPrefs.SetInt("DebraChem", 0);
        PlayerPrefs.SetInt("ChemDKey", 0);
        PlayerPrefs.SetInt("BeakerWin", 0);
        PlayerPrefs.SetInt("ChemJanitor", 0);
    }
    
}
