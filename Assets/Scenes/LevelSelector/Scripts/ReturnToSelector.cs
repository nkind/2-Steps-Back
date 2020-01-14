using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToSelector : MonoBehaviour {

    public void LoadLevel() {
        SceneManager.LoadScene("LevelSelector");
    }
}
