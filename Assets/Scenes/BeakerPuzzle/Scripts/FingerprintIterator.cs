using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FingerprintIterator : MonoBehaviour {
    
    public GameObject confetti;

    public GameObject[] fingerprints;

    public int current;

    private void Start() {
        current = 0;
        fingerprints[current].GetComponent<SpriteRenderer>().enabled = true;
    }

    public void Next() {
        int next = current + 1;
        
        if (next >= fingerprints.Length) {
            next = 0;
        }

        fingerprints[current].GetComponent<SpriteRenderer>().enabled = false;
        fingerprints[next].GetComponent<SpriteRenderer>().enabled = true;
        current = next;
    }

    public void Prev() {
        int prev = current - 1;
        
        if (prev <= 0) {
            prev = 7;
        }

        fingerprints[current].GetComponent<SpriteRenderer>().enabled = false;
        fingerprints[prev].GetComponent<SpriteRenderer>().enabled = true;
        current = prev;
    }

    public void Submit() {
        if (current == 7) {
            confetti.GetComponent<SpriteRenderer>().enabled = true;
            PlayerPrefs.SetInt("BeakerWin", 1);
            PlayerPrefs.SetInt("BeakerPuzzleRead", 1);
            SceneManager.LoadScene("ChemLabLeft");
        } else {
            confetti.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}
