using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoTutorial : MonoBehaviour {
    void Awake() {
        StartCoroutine(TutorialMessage());
    }

    IEnumerator TutorialMessage() {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }   
}
