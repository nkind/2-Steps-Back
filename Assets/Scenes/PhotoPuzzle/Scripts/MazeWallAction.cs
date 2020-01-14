using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWallAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            collision.collider.SendMessage("Reposition");
            //collision.collider.transform.position = new Vector2(-4.5f, 3.5f);
        }
    }
}
