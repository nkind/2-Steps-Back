using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ComplexResult : MonoBehaviour {

    void Awake() {
        StartCoroutine(ScoreResult());
    }

    IEnumerator ScoreResult() {
        yield return new WaitForSeconds(38.0f);

        float score = PlayerPrefs.GetInt("Score");
        Debug.Log(score);
        if (score >= 5000) {
            GetComponent<Text>().text = "Hack Completed";
            PlayerPrefs.SetInt("PassHek", 1);
            SceneManager.LoadScene("DebraOffice");
        } else {
            GetComponent<Text>().text = "Hacking Failed";
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("ComplexityRhythmPuzzle");        }
    }   
}
