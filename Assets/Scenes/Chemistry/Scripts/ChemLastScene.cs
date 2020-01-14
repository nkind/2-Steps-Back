using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemLastScene : MonoBehaviour
{
    public GameObject janitor;
    public GameObject keyRemind;
    public GameObject haveKey;

    void Awake()
    {
        int var = PlayerPrefs.GetInt("ChemJanitor");
        if (var == 1)
        {
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            janitor.SetActive(false);
        }
    }

    public void LobbyJanitor()
    {
        PlayerPrefs.SetInt("ChemJanitor", 1);
    }
    public void KeyRemindClose()
    {
        keyRemind.SetActive(false);
    }
    public void HaveKey()
    {
        haveKey.SetActive(false);
    }
    public void CheckKey()
    {
        int key = PlayerPrefs.GetInt("Key");
        if(key == 1)
        {
            haveKey.SetActive(true);
        }
        else
        {
            keyRemind.SetActive(true);
        }
    }
}
