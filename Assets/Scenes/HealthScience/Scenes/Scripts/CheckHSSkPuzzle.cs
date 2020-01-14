using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHSSkPuzzle : MonoBehaviour
{
    public GameObject handPuzzle;
    public GameObject solovePuzzle;
    public GameObject BG1;
    public GameObject BGSolove;
    void Update()
    {
        int var1 = PlayerPrefs.GetInt("SolvedSkeleton");
        if (var1 == 1)
        {
            handPuzzle.SetActive(false);
            solovePuzzle.SetActive(true);
            BG1.SetActive(false);
            BGSolove.SetActive(true);
            //allow access to thorv on map
            PlayerPrefs.SetInt("Thorv", 1);
        }
        else
        {
            handPuzzle.SetActive(true);
            solovePuzzle.SetActive(false);
            BG1.SetActive(true);
            BGSolove.SetActive(false);
        }
    }

   
}
