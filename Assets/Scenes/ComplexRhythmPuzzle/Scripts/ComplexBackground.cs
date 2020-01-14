using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexBackground : MonoBehaviour {

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
        sr.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        sr.color = old;
    } 
}
