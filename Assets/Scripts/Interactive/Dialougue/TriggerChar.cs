using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerChar : MonoBehaviour
{
    public Dialgue sentence;
    public CharacterManager manager;
    public GameObject box;
 
    public GameObject character;
    public bool needChoice;

    public GameObject DoYouWantSomethingShow;

    public static TriggerChar Instance;


     void Start()
    {
        Instance = this;
    }
    void Update()
    {
        if (CharacterManager.Instance.disappera == true && character != null)
        {
            character.SetActive(false);
            if (DoYouWantSomethingShow != null)
            {
                DoYouWantSomethingShow.SetActive(true);
            }
            CharacterManager.Instance.disappera = false;           
        }
        if(CharacterManager.Instance.disappera == true && box != null)
        {
            
            box.SetActive(true);
            CharacterManager.Instance.disappera = false;
            
        }             
      

    }

    // public Sprite image;


    public void OnTouchDown()
    {
        FindObjectOfType<CharacterManager>().StartDialogue(sentence);

    }


}
