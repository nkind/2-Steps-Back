using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[System.Serializable]
public class TestCharacter : MonoBehaviour
{
    private CharacterInformation characterPanel;

    private UnityAction myNextAction;
    private UnityAction myCloseAction;
    public Sprite image;
    public string[] sentences;

     void Awake()
    {
        characterPanel = CharacterInformation.Instance();
        myNextAction = new UnityAction(NextFunction);
        myCloseAction = new UnityAction(CloseFunction);
    }

    void OnTouchDown()
    {
        characterPanel.CharacterBox(image, myNextAction,myCloseAction, sentences);
    }
    void NextFunction()
    {
        Debug.Log("I am button Next");
    }
    void CloseFunction()
    {

    }
}
