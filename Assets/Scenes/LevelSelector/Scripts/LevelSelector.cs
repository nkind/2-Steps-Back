using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

    void Start() {
        // Screen.autorotateToPortrait = true;
    }
    // Update is called once per frame
    void Update() {
        // Screen.orientation = ScreenOrientation.Portrait;
    }

    public void LoadLevel(string level) {
       
        if(PlayerPrefs.GetInt("DinoFinishPEPE")==1 && level == "ArriveFirstTime")
        {
            SceneManager.LoadScene("FinishDino");
        }
        if(PlayerPrefs.GetInt("PassHek") == 1)
        {
            SceneManager.LoadScene("DebraOffice");
        }
        else
        {
            SceneManager.LoadScene(level);
        }
    }
}
