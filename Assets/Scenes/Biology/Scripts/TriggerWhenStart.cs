using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWhenStart : MonoBehaviour
{
    public Dialgue sentence;
    public CharacterManagerStartOnce manager;
    public GameObject box;

    public GameObject character;
    public bool needChoice;

    public GameObject DoYouWantSomethingShow;
    public GameObject DoYouWantSomethingShow2;

    public static TriggerWhenStart Instance;

    public bool disapper1BeforeLast;

    public float howManyLef;

    void Start()
    {
     Instance = this;

     FindObjectOfType<CharacterManagerStartOnce>().StartDialogue(sentence);
           
        
       
    }
    void Update()
    {

   
        if (CharacterManagerStartOnce.Instance.disappera == true)
        {
            if(character!= null)
            {
                character.SetActive(false);
            }
            
            if (DoYouWantSomethingShow != null)
            {
                DoYouWantSomethingShow.SetActive(true);
            }
            if (DoYouWantSomethingShow2 != null)
            {
                DoYouWantSomethingShow2.SetActive(true);
            }
            CharacterManagerStartOnce.Instance.disappera = false;
        }
        if (CharacterManagerStartOnce.Instance.disappera == true && box != null)
        {

            box.SetActive(true);
            CharacterManagerStartOnce.Instance.disappera = false;

        }


    }

    // public Sprite image;


    public void OnTouchDown()
    {
        FindObjectOfType<CharacterManagerStartOnce>().StartDialogue(sentence);

    }
}
