using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComplexActivator : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    GameObject note;
    
    float screenWidth;

    public bool createMode;

    public GameObject background;

    private void Start() {
        screenWidth = Screen.width;
    }


    public void ActivatorPressed() {
        if (active) {
            if (note.tag == "Note") {
                AddScore();
                Destroy(note);
                // lane.GetComponent<SpriteRenderer>().color;
            } 
            if (note.tag == "Mystery Note") {
                AddScore();
                note.SendMessage("MysteryEffect");
                note.SendMessage("DelayedDestroy");
                // lane.GetComponent<SpriteRenderer>().color;
            }
            if (note.tag == "Trap Note") {
                LoseScore();
                background.SendMessage("Flash");
                Destroy(note);
            }
        } else {
            LoseScore();
        }
        
        active = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        active = true;
        if (other.gameObject.tag == "Note" || other.gameObject.tag == "Mystery Note" || other.gameObject.tag == "Trap Note" ) {
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
