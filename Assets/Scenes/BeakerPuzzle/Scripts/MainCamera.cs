using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamera : MonoBehaviour {
    void Start() {
        Screen.autorotateToLandscapeLeft = true;
    }
    // Update is called once per frame
    void Update() {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void GoToDoor()
    {
        SceneManager.LoadScene("Hong");
    }
    public void GoToLab()
    {
        SceneManager.LoadScene("Secret Lab");
    }
    public void GoToLabBox()
    {
        SceneManager.LoadScene("Secret Lab Boxes");
    }
}
