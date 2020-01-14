using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    private Queue<string> sentences;
    //public Text nameText;
    public Text dialogueText;
    //public GameObject con;
    public GameObject canvas;
    public GameObject optionBox;
    public GameObject optionChoice;
    public bool disappera;
    public bool LoadScene;
	public bool phoneUI;

   

    public static CharacterManager Instance;
    // Start is called before the first frame update
    void Awake()
    {
        sentences = new Queue<string>();
        Instance = this;
        disappera = false;
        LoadScene = false;
    }

    public void StartDialogue(Dialgue dialogue)
    {
        Debug.Log("Srarting conversation with" + dialogue.name);
        canvas.SetActive(true);
        

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNext();
    }

    public void DisplayNext()
    {
        //if(sentences.Count == TriggerWhenStart.Instance.howManyLef && TriggerWhenStart.Instance.disapper1BeforeLast == true)
        //{
        //    TriggerWhenStart.Instance.character.SetActive(false);
        //}
        if(sentences.Count == 0)
        {
            EndDialogue();
            
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {

        LoadScene = true;
		if (phoneUI == false)
        canvas.SetActive(false);
        if(TriggerChar.Instance.needChoice == true)
        {
            if (optionBox != null)
            {
                optionBox.SetActive(true);
            }
            if (optionChoice != null)
            {
                optionChoice.SetActive(true);
            }
        }
        
        if(TriggerChar.Instance.needChoice == false)
        {
            disappera = true;
        }
        
    }

 

   
}
