using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropletAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y <= -4.5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            collision.collider.SendMessage("Reposition");
            //collision.collider.transform.position = new Vector2(-4.5f, 3.5f);
        }
    }
}
