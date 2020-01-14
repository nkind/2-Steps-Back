using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    public Button upButton, downButton, leftButton, rightButton;

    float speed = 6;

    int xPos, yPos;

    // Update is called once per frame
    private void Start()
    {
        xPos = yPos = 0;
        upButton.onClick.AddListener(UpClick);
        downButton.onClick.AddListener(DownClick);

    }

    void UpClick()
    {
        if (yPos >= 1)
        {
           // gameObject.transform.position.x + 
            return;
        }
        yPos += 1;
        transform.Translate(new Vector3(0, speed, 0));
    }

    void DownClick()
    {
        if (yPos <= -1) {
            return;
        }
        yPos -= 1;
        transform.Translate(new Vector3(0, -speed , 0));
    }

    



}
