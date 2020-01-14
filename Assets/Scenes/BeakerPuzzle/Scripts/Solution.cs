using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour {

    public void Hide() {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    public void Show() {
        GetComponent<SpriteRenderer>().enabled = true;
    } 
}
