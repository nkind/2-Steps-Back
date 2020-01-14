using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public Text information;
    public string content;
    public string DesctiptionText;
    public GameObject bubblebox;
    private int start;

    public Text Description;

    public void SetText()
    {
        bubblebox.SetActive(true);
        information.text = content;
        Description.text = DesctiptionText;
    }
}
