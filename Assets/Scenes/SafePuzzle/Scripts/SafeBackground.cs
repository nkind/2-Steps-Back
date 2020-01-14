using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeBackground : MonoBehaviour {

    private Color old;
    private Image sr;

    void Awake() {
        sr = GetComponent<Image>();
    }

    private void Start() {
        old = sr.color;
    }
    
    public void FlashGreen() {
        StartCoroutine(FlashGreenRoutine());
    }
    public void FlashRed() {
        StartCoroutine(FlashRedRoutine());
    }

    IEnumerator FlashRedRoutine() {
        sr.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    } 

    IEnumerator FlashGreenRoutine() {
        sr.color = Color.green;
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    } 
}
