using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    string combo;
    Animator smoke;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        combo = "";
        smoke = this.gameObject.GetComponent<Animator>();
    }
    IEnumerator Smoke()
    {
        smoke.Play("Smoke");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    //add to combo
    public void choice(char aColorOfChemical)
    {
        combo += aColorOfChemical;
    }

    // Update is called once per frame
    void Update()
    {
        if (combo == "rbpg")
        {
            //Player got it right
            Debug.Log("Correct, do whatever is next");
            SceneManager.LoadScene("ChemLabLeft");
            PlayerPrefs.SetInt("ChemPass", 1);
        }
        //Wasnte empty so they got it wrong.
        else if (combo != "" && combo.Length >= 4)
        {
            //playsmoke and reset
            StartCoroutine("Smoke");
        }
    }
}
