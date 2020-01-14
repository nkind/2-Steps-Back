using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    private Queue<string> sentences;

    public Text dialogueText;

    public GameObject canvas;
    
    public GameObject CharacterDisapper;

    public GameObject optionA;
    public GameObject optionB;
    public bool disapp;

    public static OptionManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        sentences = new Queue<string>();


    }

    public void StartDialogue(Dialgue dialogue)
    {
        Debug.Log("Srarting conversation with" + dialogue.name);
        //canvas.SetActive(true);

        optionA.SetActive(true);
        optionB.SetActive(true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNext();
    }

    public void DisplayNext()
    {
        if(TriggerOption.Instance.Disappera == true && sentences.Count == TriggerOption.Instance.howmany)
        {
            disapp = true;
        }
        if(sentences.Count==TriggerOption.Instance.howmanyAppear && TriggerOption.Instance.appear2 != null)
        {
            TriggerOption.Instance.appear2.SetActive(true);
        }
        if(sentences.Count == TriggerOption.Instance.HomanyFor2 && TriggerOption.Instance.disappera2 != null)
        {
            TriggerOption.Instance.disappera2.SetActive(false);
        }
        if (sentences.Count == 0)
        {
            dialogueText.text = "";
            
            EndDialogue();
            
            return;
        }
        
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        
        Debug.Log("end of conversation");
       // dialouBox.SetActive(true);
        canvas.SetActive(false);
        
        dialogueText.gameObject.SetActive(false);
        CharacterDisapper.SetActive(false);

        if(TriggerOption.Instance.appear != null)
        {
            TriggerOption.Instance.appear.SetActive(true);
        }
    }



}
