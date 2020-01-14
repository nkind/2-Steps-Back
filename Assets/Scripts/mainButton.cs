
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainButton : MonoBehaviour
{
    public void changeScene(string sceneName)
    {
        if (PlayerPrefs.GetInt("Microfiche") == 1) {
            SceneManager.LoadScene("Microscope");
        } else {
            gameObject.SendMessage("SetText");
        }

        Time.timeScale = 1.0f;
    }
}
