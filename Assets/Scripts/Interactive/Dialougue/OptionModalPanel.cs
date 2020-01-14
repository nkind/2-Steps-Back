using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class OptionModalPanel : MonoBehaviour
{
    public Text optionA;
    public Text optionB;
    public Text optionC;
    public Button A;
    public Button B;
    public Button C;

    public GameObject OptionBox;

    private static OptionModalPanel modalpanel;

    public static OptionModalPanel Instance()
    {
        if (!modalpanel)
        {
            modalpanel = FindObjectOfType(typeof(OptionModalPanel)) as OptionModalPanel;
            if (!modalpanel)
                Debug.LogError("Need to be one active");

        }
        return modalpanel;
    }


    public void Choice(string OptionA, string OptionB, string OptionC)
    {
        OptionBox.SetActive(true);
        this.optionA.text = OptionA;
        this.optionB.text = OptionB;
        this.optionC.text = OptionC;
    }
    public void ClickA()
    {
        Debug.Log(optionA.text);
    }
    public void ClickB()
    {
        Debug.Log(optionB.text);
    }
    public void ClickC()
    {
        Debug.Log(optionC.text);
    }
}
