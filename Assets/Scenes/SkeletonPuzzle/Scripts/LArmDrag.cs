using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LArmDrag : MonoBehaviour {

    [SerializeField]
    private Transform lArmPlace;

    private Vector2 initialPos;

    private float deltaX, deltaY;

    public static bool locked;

    // Start is called before the first frame update
    void Start() {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0 && !locked) {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase) {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)) {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)) {
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    }
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - lArmPlace.position.x) <= 0.5f && 
                        Mathf.Abs(transform.position.y - lArmPlace.position.y) <= 0.5f ) {
                            transform.position = new Vector2(lArmPlace.position.x, lArmPlace.position.y);
                            locked = true;
                    } else {
                        transform.position = new Vector2(initialPos.x, initialPos.y);
                    }
                    break;
            }
        }
    }
}
