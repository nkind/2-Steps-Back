using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTrigger : MonoBehaviour
{
    public Dialgue sentence;
    public ArrayDialegue manager;
    public GameObject box;

    // public Sprite image;


    public void OnTouchDown()
    {
        FindObjectOfType<ArrayDialegue>().StartDialogue(sentence);

    }
}
