using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BioButtonUse : MonoBehaviour
{
    
    public void ChemLobbyToLab()
    {
        SceneManager.LoadScene("ChemLabLeft");
        PlayerPrefs.SetInt("ChemStart", 1);
    }
    public void ChemLabToLobby()
    {
        SceneManager.LoadScene("ChemistryLobby");
    }
    public void ChemLabToFinalLobby()
    {
        SceneManager.LoadScene("ChemFinal");
    }
    public void ChemLab2To1()
    {
        SceneManager.LoadScene("ChemLabLeft");
    }
    public void ChemLab1To2()
    {
        SceneManager.LoadScene("ChemLabRight");
    }
    public void ChemLab2ToBack()
    {
        SceneManager.LoadScene("ChemLabBack");
    }
    public void ChemBackTo2()
    {
        SceneManager.LoadScene("ChemLabRight");
    }
    public void DebraGone()
    {
        PlayerPrefs.SetInt("DebraChem", 1);
    }
    public void EnterBeaker()
    {
        SceneManager.LoadScene("Beaker");
    }
    public void ReadPuzzleResult()
    {
        PlayerPrefs.SetInt("BeakerPuzzleRead",0);
    }
    public void ReadPuzzleResultReal()
    {
        PlayerPrefs.SetInt("BeakerRead", 1);
    }
    public void ThomasTalked()
    {
        PlayerPrefs.SetInt("ThomasTalkedP", 1);
    }
    

}
