using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUse : MonoBehaviour
{
    public GameObject alltheButton;
    public GameObject background; //hide the background image

    public void ButtonDisappera()
    {
        
        alltheButton.SetActive(false);
        background.SetActive(false);
    }
}
