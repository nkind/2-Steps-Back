using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour {

    private Color old;
    private SpriteRenderer sr;

    void Awake() {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        old = sr.color;
    }
    
    public void Flash() {
        StartCoroutine(Pressed());
    }

    IEnumerator Pressed() {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    } 
    public void FlashRed() {
        StartCoroutine(BadPress());
    }

    IEnumerator BadPress() {
        sr.color = Color.red;
        yield return new WaitForSeconds(0.15f);
        sr.color = old;
    } 
}
