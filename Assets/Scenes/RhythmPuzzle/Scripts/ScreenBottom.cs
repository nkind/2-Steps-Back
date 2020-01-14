using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBottom : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Note") {
            Destroy(other.gameObject);

        }   

        float oldScore = PlayerPrefs.GetInt("Score");

        if (oldScore <= 0) {
            return;
        }

        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 100);
 
    }
}
