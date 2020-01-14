using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleRoomCheck : MonoBehaviour
{
    public GameObject hand;

    // Update is called once per frame
    void Update()
    {
        int var = PlayerPrefs.GetInt("Hand");
        if(var == 1)
        {
            hand.SetActive(false);

        }
        else
        {
            hand.SetActive(true);
        }
    }
}
