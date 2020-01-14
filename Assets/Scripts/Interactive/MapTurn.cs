using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTurn : MonoBehaviour
{
    public Transform caPosition;
    private float timer;
    private bool canMove = false;
    private float speed = 5;

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
        if (timer > 1)
        {
            
            timer = 0;
            canMove = false;
        }

        
    }
    void OnTouchDown()
    {

        canMove = true;
    }
}
