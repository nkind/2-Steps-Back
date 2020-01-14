using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingTouch : MonoBehaviour
{
    public Color defaultColour;
    public Color selectColour;
    private SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void OnTouchDown()
    {
        render.color = selectColour;
        Debug.Log("hi");
    }
    void OnTouchUp()
    {
        render.color = defaultColour;
    }
    void OnTouchStay()
    {
        render.color = selectColour;
    }
    void OnTouchExit()
    {
        render.color = defaultColour;
    }
}
