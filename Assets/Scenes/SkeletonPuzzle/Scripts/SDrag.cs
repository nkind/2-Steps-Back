using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SDrag : MonoBehaviour {

    [SerializeField]
    private Transform piecePlace;

    private Vector2 initialPos;

    private float deltaX, deltaY;

    public bool locked;

    public static int lockedPieces = 0;

    public GameObject[] OtherPieces;

    private bool grabbed;

    private Color originalColor;


    // Start is called before the first frame update
    void Start() {
        initialPos = transform.position;
        originalColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0 && !locked) {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase) {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)) {
                        grabbed = true;
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                        HideOthers();
                    }
                    break;
                case TouchPhase.Moved:
                    if (grabbed) {
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    }
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - piecePlace.position.x) <= 0.5f && 
                        Mathf.Abs(transform.position.y - piecePlace.position.y) <= 0.5f ) {
                            transform.position = new Vector2(piecePlace.position.x, piecePlace.position.y);
                            locked = true;
                            lockedPieces++;
                            GetComponent<Collider2D>().enabled = false;
                    } else {
                        transform.position = new Vector2(initialPos.x, initialPos.y);
                    }
                    grabbed = false;
                    ShowOthers();
                    break;
            }
        }
        if (lockedPieces >= 16) {
            PlayerPrefs.SetInt("SolvedSkeleton", 1);
            SceneManager.LoadScene("Morgue");

        }
    }

    private void HideOthers() {
        foreach (GameObject piece in OtherPieces) {
            piece.SendMessage("Hide");
        }
    }

    private void ShowOthers() {
        foreach (GameObject piece in OtherPieces) {
            piece.SendMessage("Show");
        }
    }


    public void Hide()
    {
        if (!locked)
        {   
            Color newColor = originalColor;
            newColor.a -= 0.5f;
            GetComponent<SpriteRenderer>().color = newColor;
            GetComponent<Drag>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
        }
    }

    public void Show()
    {
        if (!locked)
        {
            Color newColor = originalColor;
            GetComponent<SpriteRenderer>().color = originalColor;
            GetComponent<Drag>().enabled = true;
            GetComponent<Collider2D>().enabled = true;
        }
    }

}
