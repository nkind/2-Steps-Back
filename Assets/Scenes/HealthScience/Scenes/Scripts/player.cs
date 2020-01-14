using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
   
    void Start() {
        // DontDestroyOnLoad(gameObject);
        
    }

    public void LoadSamlpeRoom() {
        int hasHandBone = PlayerPrefs.GetInt("HandBone");
        int passedKeypad = PlayerPrefs.GetInt("KeyPad");
        
        //if (hasHandBone == 1) {
        //    SceneManager.LoadScene("SampleRoom2");
        //    return;
        //}

        if (passedKeypad == 1) {
            SceneManager.LoadScene("SampleRoom");
            return;
        }

        SceneManager.LoadScene("KeyPad");
    }

    public void LoadSkeleton(GameObject bagOfBones) {
        //int hasHandBone = PlayerPrefs.GetInt("HandBone");
        int hasHandBone = PlayerPrefs.GetInt("Hand");
        int solvedSkeleton = PlayerPrefs.GetInt("SolvedSkeleton");
        
        if ((hasHandBone == 1) && (solvedSkeleton == 0)) {
            SceneManager.LoadScene("Skeleton");
        } else {
            
            bagOfBones.SendMessage("OnTouchDown");
        }
    }

    public void AddItem(string clue) {
        PlayerPrefs.SetInt(clue, 1);
        // PlayerPrefs.SetInt("Hand", 1);
    }


}
