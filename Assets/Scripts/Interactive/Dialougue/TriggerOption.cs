using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerOption : MonoBehaviour
{
    public Dialgue sentence;
    public OptionManager manager;
    public GameObject appear;
    public GameObject appear2;
    public float howmanyAppear;
    public GameObject disappera2;
    public float HomanyFor2;

    public GameObject textbox;

    public GameObject gone;
    public bool Disappera;
    public float howmany;

    public static TriggerOption Instance;

     void Start()
    {
        Instance = this;
    }

    public void OnTouchDown()
    {
        FindObjectOfType<OptionManager>().StartDialogue(sentence);
        textbox.SetActive(true);
    }

     void Update()
    {
        if(OptionManager.Instance.disapp == true && gone != null)
        {
            gone.SetActive(false);
        }
    }
}
