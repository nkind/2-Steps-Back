using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour {

    public string color;

    private void Start() {
        Screen.autorotateToPortrait = true;
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update() {
        int keyValue = PlayerPrefs.GetInt(color);

        if (keyValue == -1) {
            GetComponent<Text>().text = "";    
        } else {
            GetComponent<Text>().text = keyValue.ToString();
        }

    }
}
