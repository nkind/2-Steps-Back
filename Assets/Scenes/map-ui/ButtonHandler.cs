using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

    public GameObject Panel;
    public Text dialog;
    private string scene;

    // open the panel asking player being sure to return to the crime scene
    public void OpenPanel(){
        // clicking on different map button leads to different texts
        string destination = gameObject.name;
        PlayerPrefs.SetString("destination", destination);
        switch (destination)
        {
            case "AdminButton":
                dialog.text = "Return To Administration Building?";
                
                break;
            case "ChemButton":
                dialog.text = "Return To Chemistry Lab?";
                break;
            case "HSButton":
                dialog.text = "Return To Health Science?";
                break;
            case "BioButton":
                dialog.text = "Return To Biology Building?";
                break;
            default:
                dialog.text = "Return To Arts Building?";
                break;
        }
        Panel.SetActive(true);

    }

    //close panel when the answer is choosed
    public void ClosePanel(){
        

        // if yes, go back to the crime scene
        if(gameObject.name=="YesButton"){

           string destination = PlayerPrefs.GetString("destination");
            Debug.Log(destination);
            switch (destination)
            {
                case "AdminButton":
                    SceneManager.LoadScene("Admin", LoadSceneMode.Additive);
                    break;
                case "ChemButton":
                    SceneManager.LoadScene("ChemFinal", LoadSceneMode.Additive);
                    break;
                case "HSButton":
                    SceneManager.LoadScene("Morgue", LoadSceneMode.Additive);
                    break;
                case "BioButton":
                    SceneManager.LoadScene("BioFinal", LoadSceneMode.Additive);
                    break;
                default:
                    SceneManager.LoadScene("Arts", LoadSceneMode.Additive);
                    break;
            }
        }
        else{
            Panel.SetActive(false);
        }
    }

    public void ReturnToMap(){
        SceneManager.LoadScene("MapScene", LoadSceneMode.Additive); //return button
    }

    public void OpenStaticMap(){
        SceneManager.LoadScene("static_map", LoadSceneMode.Additive); //return button
    }

}
