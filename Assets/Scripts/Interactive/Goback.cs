using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goback : MonoBehaviour
{
    public static string backZoom = "n";
    public Transform caPosition;
    private float speed = 5;

    private bool canMove = false;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position != caPosition.position && canMove == true)
        {
            StartMove();
        }
        
    }
    void StartMove()
    {
        Vector3 newPos = new Vector3(caPosition.transform.position.x, caPosition.transform.position.y, caPosition.transform.position.z);

        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, newPos, speed * Time.deltaTime);
        timer += Time.deltaTime;
        if (timer > 1)
        {
            backZoom = "n";
            timer = 0;
            gameObject.SetActive(false);
            canMove = false;
        }
        
    }
    void OnTouchDown()
    {    
        backZoom = "y";
        canMove = true;
        Debug.Log("here");
    }
}
