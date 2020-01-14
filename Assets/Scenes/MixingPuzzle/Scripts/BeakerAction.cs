using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakerAction : MonoBehaviour
{
    public Sprite emptyBeaker;
    Animator anim;
    bool tappable = true;
    //Set to true if player can add same liquid twice.
    bool reUseable = false;
    //only matters in the case inwhich we can only be used once
    bool wasTapped = false;

    //Send messages to other beakers.
    Transform root;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        //initialize the root
        root = this.transform;
        while (root.parent != null)
        {
            root = root.parent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!tappable)
        {
            //If its not tappable, disable the collider
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            //it is tappable, reenable it
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

    }


    //tell others to disable
    public void disable()
    {
        tappable = false;
    }

    public void enable()
    {
        if(!wasTapped || reUseable) { tappable = true; } 
    }

    public void checkForReuse()
    {
        //Only do this if we dont want to be reuseable.
        if (!reUseable)
        {
            //not reusable so disable animation and just show the empty one
            anim.enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = emptyBeaker;
        }
        //It is reuseable so turn back on my collider
        else
        {
            tappable = true;
        }
    }
    IEnumerator Blue()
    {
        tappable = false;
        wasTapped = true;
        //Dont let others get tapped.
        root.BroadcastMessage("disable");
        //1.92 becasue the blue pouring animation is 1:55 seconds which is 1 + 55/60 = 1.92 
        yield return new WaitForSeconds(1.92f);
        checkForReuse();
        //Still might need to enable others. 
        root.BroadcastMessage("enable");
        root.BroadcastMessage("choice", 'b');
    }

    IEnumerator Red()
    {
        tappable = false;
        wasTapped = true;
        //Dont let others get tapped.
        root.BroadcastMessage("disable");
        //1.51 becasue the blue pouring animation is 1:30 seconds which is 1 + 30/60 = 1.51
        yield return new WaitForSeconds(1.51f);
        checkForReuse();
        //Still might need to enable others. 
        root.BroadcastMessage("enable");
        root.BroadcastMessage("choice", 'r');
    }

    IEnumerator Green()
    {
        tappable = false;
        wasTapped = true;
        //Dont let others get tapped.
        root.BroadcastMessage("disable");
        //1.84 becasue the blue pouring animation is 1:50 seconds which is 1 + 50/60 = 1.84
        yield return new WaitForSeconds(1.84f);
        checkForReuse();
        //Still might need to enable others. 
        root.BroadcastMessage("enable");
        root.BroadcastMessage("choice", 'g');
    }

    IEnumerator Purple()
    {
        tappable = false;
        wasTapped = true;
        //Dont let others get tapped.
        root.BroadcastMessage("disable");
        //1.17 becasue the blue pouring animation is 1:10 seconds which is 1 + 10/60 = 1.17
        yield return new WaitForSeconds(1.17f);
        checkForReuse();
        //Still might need to enable others. 
        root.BroadcastMessage("enable");
        root.BroadcastMessage("choice", 'p');
    }

    void OnMouseUp()
    {
        if (gameObject.name == "BlueBeaker")
        {
            anim.Play("PourBlue");
            StartCoroutine("Blue");
        }
        if (gameObject.name == "RedBeaker")
        {
            anim.Play("PourRed");
            StartCoroutine("Red");
        }
        if (gameObject.name == "GreenBeaker")
        {
            anim.Play("PourGreen");
            StartCoroutine("Green");
        }
        if (gameObject.name == "PurpleBeaker")
        {
            anim.Play("PourPurple");
            StartCoroutine("Purple");
        }

    }
}
