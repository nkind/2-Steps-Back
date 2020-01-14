using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Activator : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    bool pressed = false;
    public string activatorColor;
    GameObject note;
    

    float screenWidth;

    public bool createMode;
    public GameObject n;

    private void Start() {
        screenWidth = Screen.width;
    }

    // Update is called once per frame
    // void FixedUpdate() {
    //     if (createMode && Input.GetKeyDown(key)) {
    //         Instantiate(n, transform.position, Quaternion.identity);
    //         return;    
    //     }
        
    //     for (int i = 0; i < Input.touchCount; i++) {
    //         float xPos = Input.GetTouch(i).position.x;
    //         if (xPos < screenWidth / 4) { //left side
    //             if (activatorColor == "Blue") {
    //                 pressed = true;
    //             }
                
    //         } else if (xPos < screenWidth / 2) { // left middle
    //             if (activatorColor == "Green") {
    //                 pressed = true;
    //             }

    //         } else if (xPos < screenWidth * 3 / 4) { // right middle
    //             if (activatorColor == "Yellow") {
    //                 pressed = true;
    //             }

    //         } else {
    //             if(activatorColor == "Red") {
    //                 pressed = true;
    //             }
    //         }

    //         if (pressed) {
    //             if (active) {
    //                 AddScore();
    //             } else {
    //                 LoseScore();
    //             }
    //             StartCoroutine(Pressed());
    //             Destroy(note);
    //             pressed = false;
    //             active = false;
    //         }
    //     }

    // }

    public void ActivatorPressed() {
        if (active) {
            AddScore();
        } else {
            LoseScore();
        }
        Destroy(note);
        pressed = false;
        active = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        active = true;
        if (other.gameObject.tag == "Note") {
            note = other.gameObject;
        }    
    }

    void OnTriggerExit2D(Collider2D other) {
        active = false;    
    }

    void AddScore() {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);
    }

    void LoseScore() {
        float oldScore = PlayerPrefs.GetInt("Score");

        if (oldScore <= 0) {
            return;
        }

        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 100);
    }
}
