using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Image timerBar;
    float timer = 10f;
    float time;
    //public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        //Since Bar is the first child. It is obtaining that image
        //timerBar = this.GetComponentInChildren<Image>();
        time = timer;
    }

    IEnumerator LightsFlicker()
    {
        GameObject.FindGameObjectWithTag("Dark").GetComponent<SpriteRenderer>();
        yield return new WaitForSeconds(0.25f);
        GameObject.FindGameObjectWithTag("Dark").transform.position = new Vector3(0, -5, -2);
        StartCoroutine("LightsOut");
    }

    IEnumerator LightsOut()
    {
        yield return new WaitForSeconds(0.25f);
        GameObject.FindGameObjectWithTag("Dark").transform.position = new Vector3(0, 0, -2);
        StartCoroutine("LightsOn");
    }

    IEnumerator LightsOn()
    {
        yield return new WaitForSeconds(2f);
        GameObject.FindGameObjectWithTag("Dark").transform.position = new Vector3(0, 10, -2);
        //timerBar.color = Color.black;
        //timeText.color = Color.black;
        //timeText.fontSize = 60;
        time = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            /* ALL CODE FOR THE TIMER VISUAL. Left just incase
            timerBar.fillAmount = time / timer;
            timeText.text = time.ToString("F");
            //less that a third left
            if (time <= 0.33 * timer)
            {
                timerBar.color = Color.red;
                timeText.color = Color.red;
                timeText.fontSize = 70;
            }
            */
        }
        else// Time is less than 0. Set time to 0 for display purposes, or else it may show -0.01 which is weird.
        {
            //timeText.text = "0.00"; More code For Visuals
            //StartCoroutine("LightsFlicker");

        }
    }
}
