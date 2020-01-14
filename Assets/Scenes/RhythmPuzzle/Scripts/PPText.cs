using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour {

    public string name;

    // Start is called before the first frame update
    void Start() {
        PlayerPrefs.SetInt("Score", 0);
    }

    // Update is called once per frame
    void Update() {
        GetComponent<Text>().text = PlayerPrefs.GetInt(name)+"/5000";
    }
}
