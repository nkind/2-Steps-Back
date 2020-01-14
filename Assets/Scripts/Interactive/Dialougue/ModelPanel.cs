using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ModelPanel : MonoBehaviour
{
    public Text descrition;
    public Image things;
    public GameObject modalPanelObject;
    public Button back;
    public Button add;
    public Text Title;

    private static ModelPanel modalpanel;

    public static ModelPanel Instance()
    {
        if (!modalpanel)
        {
            modalpanel = FindObjectOfType(typeof(ModelPanel)) as ModelPanel;
            if (!modalpanel)           
                Debug.LogError("Need to be one active");
                       
        }
        return modalpanel;
    }

    public void Choice(string descrition, UnityAction backEvent, UnityAction addEvent,Sprite image,string title, bool yes)
    {
        modalPanelObject.SetActive(true);

        back.onClick.RemoveAllListeners();
        back.onClick.AddListener(backEvent);
        back.onClick.AddListener(ClosePanel);

        add.onClick.RemoveAllListeners();
        add.onClick.AddListener(addEvent);
        add.onClick.AddListener(addToInventory);

        this.descrition.text = descrition;
        this.Title.text = title;

        back.gameObject.SetActive(true);
        add.gameObject.SetActive(yes);

        this.things.sprite = image;
        
    }
    void ClosePanel()
    {
        modalPanelObject.SetActive(false);
    }
    void addToInventory()
    {
        string title = Title.text.ToString();
        PlayerPrefs.SetInt(title, 1);
        Debug.Log(title);
        Debug.Log(PlayerPrefs.GetInt(title));
        modalPanelObject.SetActive(false);
    }
}
