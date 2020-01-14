using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    public Vector2 GameWorldOrgin;
    public Vector2 LocPos;
    public Vector2 fakePos;
    public BoxCollider2D tappable;
    Vector2 temp;

    public void Start()
    {
        tappable = gameObject.GetComponent<BoxCollider2D>();
    }
    public void Update()
    {
        if (fakePos != temp && fakePos != Vector2.zero)
        {
            temp = fakePos;
            this.transform.position = fakePos;
        }
    }

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Health Sci"))
        {
            //load scence here
            SceneManager.LoadScene("MainLobby");
            GameObject.Find("DebugText").GetComponent<Text>().text += " Entering HS :";
        }
        if (gameObject.CompareTag("Thorv")) //Chem
        {
            //load scence here
            SceneManager.LoadScene("ChemistryLobby");
            GameObject.Find("DebugText").GetComponent<Text>().text += " Entering Chem :";
        }
        if (gameObject.CompareTag("Geo")) //Bio
        {
            //load scence here
            SceneManager.LoadScene("ArriveFirstTime");
            GameObject.Find("DebugText").GetComponent<Text>().text += " Entering Bio :";
        }
        if (gameObject.CompareTag("Admin"))
        {
            //load scence here
            GameObject.Find("DebugText").GetComponent<Text>().text += " Entering Admin :";
        }
        if (gameObject.CompareTag("SG")) // Art
        {
            //load scence here
            SceneManager.LoadScene("Arts");
            GameObject.Find("DebugText").GetComponent<Text>().text += " Entering SG :";
        }


        // Again, only for testing
        if (gameObject.CompareTag("AW"))
        {
            //load scence here
            GameObject.Find("DebugText").GetComponent<Text>().text += " Entering Aw :";
        }

    }
}
