using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayDialegue : MonoBehaviour
{

    public string[] sentence;
    private int index;

    public Text dialogueText;

    public GameObject canvas;

    public GameObject dialouBox;

    public GameObject optionA;
    public GameObject optionB;


    // Start is called before the first frame update
    void Start()
    {

        

    }

    public void StartDialogue(Dialgue dialogue)
    {
        Debug.Log("Srarting conversation with" + sentence[1]);
        canvas.SetActive(true);
        dialogueText.text = sentence.ToString();
        //optionA.SetActive(true);
        //optionB.SetActive(true);




        DisplayNext();
    }

    public void DisplayNext()
    {

       if(index <sentence.Length - 1)
        {
            index++;
            dialogueText.text = "";
        }
        

    }

    public void EndDialogue()
    {
        Debug.Log("end of conversation");
        // dialouBox.SetActive(true);
        canvas.SetActive(false);

    }



}
