using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexBottom : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Note") {
            Destroy(other.gameObject);

        } else if (other.gameObject.tag == "Mystery Note") {
            if (other.gameObject.GetComponent<SpriteRenderer>().enabled == false) {
                return;
            }
        } else if (other.gameObject.tag == "Trap Note") {
            return;
        }

        float oldScore = PlayerPrefs.GetInt("Score");

        if (oldScore <= 0) {
            return;
        }
        
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 100);
 
    }
}
