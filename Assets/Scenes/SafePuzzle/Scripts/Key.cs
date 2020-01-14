using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour {

    public int blue;
    public int green;
    public int yellow;
    public int red;
    AudioSource loseSound;
    AudioSource winSound;

    public GameObject background;


    void Start() {
        PlayerPrefs.SetInt("Blue", -1);
        PlayerPrefs.SetInt("Green", -1);
        PlayerPrefs.SetInt("Yellow", -1);
        PlayerPrefs.SetInt("Red", -1);
    }

    public void OnClick(int key) {
        if (PlayerPrefs.GetInt("Blue") == -1) {
            PlayerPrefs.SetInt("Blue", key);
        } else if (PlayerPrefs.GetInt("Green") == -1) {
            PlayerPrefs.SetInt("Green", key);
        } else if (PlayerPrefs.GetInt("Yellow") == -1) {
            PlayerPrefs.SetInt("Yellow", key);
        } else if (PlayerPrefs.GetInt("Red") == -1) {
            PlayerPrefs.SetInt("Red", key);
        } else {
            return;
        }
    }

    public void OpenSafe() {
        
        loseSound = GetComponents<AudioSource>()[0];
        winSound = GetComponents<AudioSource>()[1];
        
        int blueKey = PlayerPrefs.GetInt("Blue");
        int greenKey = PlayerPrefs.GetInt("Green");
        int yellowKey = PlayerPrefs.GetInt("Yellow");
        int redKey = PlayerPrefs.GetInt("Red");
        if (blueKey == blue && greenKey == green && yellowKey == yellow && redKey == red ) {
            StartCoroutine(PlaySound("win"));    
            background.SendMessage("FlashGreen");
        } else {
            StartCoroutine(PlaySound("lose"));
            background.SendMessage("FlashRed");
        }
    }

    IEnumerator PlaySound(string sound) {
        if (sound == "lose") {
            loseSound.Play();
        } else {
            winSound.Play();
            yield return new WaitForSeconds(3);
            PlayerPrefs.SetInt("KeyPad", 1);
            SceneManager.LoadScene("SampleRoom");
        }
    }

    public void ClearCombination() {
        PlayerPrefs.SetInt("Blue", -1);
        PlayerPrefs.SetInt("Green", -1);
        PlayerPrefs.SetInt("Yellow", -1);
        PlayerPrefs.SetInt("Red", -1);
    }

}
