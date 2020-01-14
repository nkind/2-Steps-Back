using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Result : MonoBehaviour {

    void Awake() {
        StartCoroutine(ScoreResult());
    }

    IEnumerator ScoreResult() {
        yield return new WaitForSeconds(38.0f);

        float score = PlayerPrefs.GetInt("Score");

        if (score >= 5000) {
            GetComponent<Text>().text = "DNA Match Found!";
            yield return new WaitForSeconds(3.0f);
            //Orginal condition
            //SceneManager.LoadScene("LastScene");
            //new condition
            SceneManager.LoadScene("ChemLabLeft");
            PlayerPrefs.SetInt("DNAPass", 1);
        } else {
            GetComponent<Text>().text = "You've got the reaction speed of a drunk snail";
            yield return new WaitForSeconds(3.0f);
            SceneManager.LoadScene("RhythmTapper");
        }
    }   
}
