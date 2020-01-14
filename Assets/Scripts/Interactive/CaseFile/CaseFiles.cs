using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseFiles : MonoBehaviour
{
    public GameObject impar;
    public GameObject janitor;
    public GameObject Debra;
    public GameObject Thomas;
    
    // Update is called once per frame
    void Update()
    {
        int imparR = PlayerPrefs.GetInt("DrMainLobby");
        if(imparR == 1)
        {
            impar.SetActive(true);
        }
        else
        {
            impar.SetActive(false);
        }
        int janitorR = PlayerPrefs.GetInt("JanitorHS");
        if (janitorR == 1)
        {
            janitor.SetActive(true);
        }
        else
        {
            janitor.SetActive(false);
        }
        int debraR = PlayerPrefs.GetInt("DebraChem");
        if (debraR == 1)
        {
            Debra.SetActive(true);
        }
        else
        {
            Debra.SetActive(false);
        }
        int thomasR = PlayerPrefs.GetInt("ThomasTalkedP");
        if (thomasR == 1)
        {
            Thomas.SetActive(true);
        }
        else
        {
            Thomas.SetActive(false);
        }
    }
}
