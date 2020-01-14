using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleTurnOn : MonoBehaviour
{
    public GameObject whatever;
    public void Touch()
    {
        whatever.SetActive(true);
       
    }

    public void GoTo()
    {
        SceneManager.LoadScene("DinoPuzzleA");
    }

    public void GoToOffice()
    {
        SceneManager.LoadScene("DebraOffice");
    }
    public void GoBackToBio()
    {
        SceneManager.LoadScene("BioThirdTime");
    }
    public void NoFinishLobby2To1()
    {
        SceneManager.LoadScene("BioNoLobby");
    }
    public void NoFinish2to3()
    {
        SceneManager.LoadScene("NoBioLobby3");
    }
    public void GoToNoFinishLobby2()
    {
        SceneManager.LoadScene("NoBioLobby2");
    }
    public void GoNoFinishLobby3()
    {
        SceneManager.LoadScene("BioLobby3");

    }
    public void NoFinish3toDoor()
    {
        SceneManager.LoadScene("NoFinishDoor");
    }
    public void NoFinishLobby2ToLobby1()
    {
        SceneManager.LoadScene("BioNoLobby");
    }
    public void NoFinis3hBackToLobby2()
    {
        SceneManager.LoadScene("NoBioLobby2");
    }
    public void NoFinisOfficehBackToLobby3()
    {
        SceneManager.LoadScene("NoBioLobby3");
    }
    public void Finish3To2()
    {
        int varCheck = PlayerPrefs.GetInt("ForeManLobby1");
        if(varCheck == 1)
        {
            SceneManager.LoadScene("BioFinal");
        }
        else
        {
            SceneManager.LoadScene("BioFinishLobby2");
        }
    }
    public void FinishOfficeToDoor()
    {
        
        PlayerPrefs.SetInt("LeaveDebraOffice", 1);
        SceneManager.LoadScene("BioFinishDoor");
    }
    public void Lobby1to2()
    {
        SceneManager.LoadScene("NoBioLobby2");
    }
    public void FinishDoorTo3()
    {
        SceneManager.LoadScene("BioFinishLobby3");
    }
    public void Finish1ToFinal()
    {
        SceneManager.LoadScene("BioFinal");
    }
    public void OfficeToDoorNoFinish()
    {
        SceneManager.LoadScene("NoFinishDoor");
    }
    public void MakeSureNoPass()
    {
        PlayerPrefs.SetInt("PassHek", 0);
        PlayerPrefs.SetInt("LeaveDebraOffice", 0);
        PlayerPrefs.SetInt("ForeManDoor", 0);
        PlayerPrefs.SetInt("ForeManLobby3", 0);
        PlayerPrefs.SetInt("ForeManLobby2", 0);
        PlayerPrefs.SetInt("ForeManLobby1", 0);
        PlayerPrefs.SetInt("bioJanitor", 0);

    }
    public void FinishDoorToOffice()
    {
        SceneManager.LoadScene("DebraOffice");
    }
    public void FinishLobby3ToDoor()
    {
        SceneManager.LoadScene("BioFinishDoor");
    }
    public void FinishLobby2To3()
    {
        SceneManager.LoadScene("BioFinishLobby3");
    }
    public void FinishLobby1To2()
    {
        SceneManager.LoadScene("BioFinishLobby2");
    }

}
