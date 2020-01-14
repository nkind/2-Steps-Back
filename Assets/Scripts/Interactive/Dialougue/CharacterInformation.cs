using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CharacterInformation : MonoBehaviour
{
    public string[] sentences;
    public Image character;
    public Button next;
    public GameObject DialgueBox;
    public GameObject panel;
    public Button close;

    private static CharacterInformation box;

    public static CharacterInformation Instance()
    {
        if (!box)
        {
            box = FindObjectOfType(typeof(CharacterInformation)) as CharacterInformation;
            if (!box)
                Debug.LogError("Need to be one active");

        }
        return box;
    }

     void Start()
    {
        //sentences = new Queue<string>();
    }

    public void CharacterBox(Sprite image, UnityAction nextEvent, UnityAction closeEvent, string[] description)
    {
        DialgueBox.SetActive(true);
        next.onClick.RemoveAllListeners();
        next.onClick.AddListener(nextEvent);
        next.onClick.AddListener(nextText);

        close.onClick.RemoveAllListeners();
        close.onClick.AddListener(closeEvent);
        close.onClick.AddListener(Close);



        this.sentences = description;
        next.gameObject.SetActive(true);

        this.character.sprite = image;
        panel.SetActive(true);
    }

    void nextText()
    {
        Debug.Log("hi");
    }

    void Close()
    {
        DialgueBox.SetActive(false);
        panel.SetActive(false);
    }
}
