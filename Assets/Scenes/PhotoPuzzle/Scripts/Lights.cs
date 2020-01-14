using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    //speed of light flash
    public float speed = 2f;
    public Color BlinkColor = Color.clear;
    public bool alphaOnly = true;

    SpriteRenderer graphic;
    bool running = false;
    Color initial;
    Color target;
    Color origin;
    double t = 0;

    float time;
    //Time between lights going out
    float timer = 10f;


    // Start is called before the first frame update
    void Start()
    {
        time = timer;
        graphic = this.GetComponent<SpriteRenderer>();
        initial = new Color(0,0,0,1);
        target = new Color(0,0,0,1);
    }
    //make lights flicker
    IEnumerator Flicker()
    {
        running = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine("Off");
    }
    //Turn lights off
    IEnumerator Off()
    {
        //stop the flciker
        running = false;
        // wait a bit
        yield return new WaitForSeconds(2f);
        graphic.color = initial;
        //Turn on lights
        On();
    }
    //Turns lights on
    public void On()
    {
        graphic.color = Color.clear;
        time = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            //Set time to be big because we will change it in lights on again anyway, just dont want lots of Corouts.
            time = 1000;
            StartCoroutine("Flicker");            
        }
        if (running)
        {
            // calculate t based on frame rate and a speed variable
            t += Time.deltaTime / speed;
            // calculate current step value - use SmoothStep for smoother animation - ease in/out
            var step = Mathf.SmoothStep(0, 1, (float)t);
            // calculate new color based on origin/target/step values
            var newColor = Color.Lerp(origin, target, step);

            // This allows us to only blink the alpha level
            if (alphaOnly)
            {
                var c = graphic.color;
                graphic.color = new Color(c.r, c.g, c.b, newColor.a);
            }
            // Otherwise we can simply interpolate between colors
            else
                graphic.color = newColor;

            // Once the target color is hit (or the target alpha is hit)
            // flip target and origin, reset time, and start again
            if (graphic.color == target ||
                (alphaOnly && graphic.color.a == target.a))
            {
                target = target == BlinkColor ? initial : BlinkColor;
                origin = origin == BlinkColor ? initial : BlinkColor;
                t = 0;
            }
        }
    }
}
