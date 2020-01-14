using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public static string zoomActive = "n";
    public Transform caPosition;

    private bool canMove = false;
    private float speed = 5;
    private float timer;

    public GameObject button;

    // Start is called before the first frame update
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
        if(timer>1)
        {
            zoomActive = "n";
            timer = 0;
            canMove = false;
        }
        button.SetActive(true);
    }
    void OnTouchDown()
    {
        zoomActive = "y";
        canMove = true;
        Debug.Log("there");
    }

}


