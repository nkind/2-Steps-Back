using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TestModalWindow : MonoBehaviour
{
    private ModelPanel modalPanel;

    private UnityAction myYesAction;
    private UnityAction myNoAction;
    public Sprite image;
    public string title;
    public string text;
    public bool wantToAdd;

    public GameObject pairedObject;

    void Awake()
    {
        modalPanel = ModelPanel.Instance();
        myYesAction = new UnityAction(TestYesFunction);
        myNoAction = new UnityAction(TestYesFunction);
        

    }
    // Send to the modal panel to set up the buttions and function
    public void OnTouchDown()
    {
        int var = PlayerPrefs.GetInt(title);
        int solvedSkeleton = PlayerPrefs.GetInt("SolvedSkeleton");

        if (title == "Bag of Bones" && solvedSkeleton == 1) {
            pairedObject.SetActive(true);
            gameObject.SetActive(false);
            return;
        }
        if(var == 1)
        {
            wantToAdd = false;
        }
        modalPanel.Choice(text, myYesAction, myNoAction,image,title,wantToAdd);
        Debug.Log("done");
    }
    void TestYesFunction()
    {

    }
}
