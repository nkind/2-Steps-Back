using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    private SpriteRenderer spriteR;
    private bool done = false;
    private bool startCall = false;

    public Dialgue sentence;

    public void TriggerFlashing()
    {
        InvokeRepeating("Flashing", 0.0f, 0.3f);
        done = false;
        startCall = true;
    }

    
    void Flashing()
    {
        spriteR.color = Color.red;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        spriteR.color = Color.white;
        if(done == true)
        {
            CancelInvoke();
            
        }

    }
    void OnTouchDown()
    {
        done = true;
        if(startCall == true)
        {
            FindObjectOfType<CharacterManager>().StartDialogue(sentence);
        }
        

    }
}
