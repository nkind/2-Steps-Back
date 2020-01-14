using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HSNavigation : MonoBehaviour {

    public void LoadArea(string area) {
        if (area == "LastArea") {
            SceneManager.LoadScene(PlayerPrefs.GetString("LastArea"));
        } else {
            string currentArea = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("LastArea", currentArea);
            SceneManager.LoadScene(area);
        }
    }
}
