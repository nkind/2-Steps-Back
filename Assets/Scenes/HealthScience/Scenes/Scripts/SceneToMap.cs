using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToMap : MonoBehaviour
{
    public void GoToMap() {
        string currentArea = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LastArea", currentArea);
        SceneManager.LoadScene("MapScene");
    }
}
