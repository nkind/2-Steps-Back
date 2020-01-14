using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadhex : MonoBehaviour
{
    public Dialgue sentence;
    public CharacterManager manager;
    public GameObject box;

    public GameObject character;
    public bool needChoice;

    public GameObject DoYouWantSomethingShow;

    public static Loadhex Instance;


    void Start()
    {
        Instance = this;
        CharacterManager.Instance.LoadScene = false;
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
        if (CharacterManager.Instance.disappera == true && box != null)
        {

            box.SetActive(true);
            CharacterManager.Instance.disappera = false;

        }
        if (CharacterManager.Instance.LoadScene == true)
        {
            SceneManager.LoadScene("ComplexRhythmPuzzle");
        }

    }

    // public Sprite image;


    public void OnTouchDown()
    {
        FindObjectOfType<CharacterManager>().StartDialogue(sentence);

    }
}
