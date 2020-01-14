using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoActions : MonoBehaviour
{
    int MapSceneIndex = 1;
    Vector2 Origin;
    //Initialize Variables
    bool isMouseDragging;
    float offSetX;
    float offSetY;
    Vector2 MousePosition;
    Vector2 objPosition;
    Vector2 photoSize;
    bool inBin;
    //User must tap photo once in bin to move on.
    bool completePhoto = false;
    //total number of sprites
    int TotalPhotos = 3;
    //counter used to keep track of progress
    int numPhotos;
    //Current sprite we are on
    int currentPhoto = 1;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite[] allSprites;
    Rigidbody2D rb;

    public Camera cam;

    int curState = 0;

    // Use this for initialization
    void Start()
    {
        Origin = gameObject.transform.position;
        Screen.orientation = ScreenOrientation.Landscape;
        photoSize = gameObject.GetComponent<Renderer>().bounds.size;
        inBin = false;
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        numPhotos = TotalPhotos;
        allSprites = new Sprite[TotalPhotos];
        allSprites[0] = sprite1;
        allSprites[1] = sprite2;
        allSprites[2] = sprite3;

    }

    void OnMouseDown()
    {
        
        MousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        objPosition = Camera.main.ScreenToWorldPoint(MousePosition);
        float tx = transform.position.x;
        float ty = transform.position.y;
        offSetX = objPosition.x - tx;
        offSetY = objPosition.y - ty;
        /* THIS IS IF YOU ONLY WANT TO GRAB EDGE.
        float limitX = photoSize.x / 2;
        float limitY = photoSize.y / 2;
        float edgeThreshold = 0.4f;
        bool inRangeX = (objPosition.x-tx >= limitX-edgeThreshold || objPosition.x-tx <= -(limitX-edgeThreshold)) ? true : false;
        bool inRangeY = (objPosition.y-ty >= limitY-edgeThreshold || objPosition.y-ty <= -(limitY-edgeThreshold)) ? true : false;    
        if (inRangeX || inRangeY)
        {
            isMouseDragging = true;
            rb.isKinematic = false;
        }
        */
        isMouseDragging = true;
        rb.isKinematic = false;
    }
    void OnMouseUp()
    {
        isMouseDragging = false;
        rb.isKinematic = true;
    }

    void Update()
    { 
        if (isMouseDragging)
        {
            MousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            objPosition = Camera.main.ScreenToWorldPoint(MousePosition);
            rb.MovePosition(new Vector2(objPosition.x - offSetX, objPosition.y - offSetY));
            /*
            bool inBoundsX = (gameObject.transform.position.x >= -7.5)  ? true : false;
            bool inBoundsUpperY = (gameObject.transform.position.y <= 3.5) ? true : false;
            bool inBoundsLowerY = (gameObject.transform.position.y >= -3.5) ? true : false;
            if (inBoundsX && inBoundsUpperY && inBoundsLowerY)
            {
                MousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                objPosition = Camera.main.ScreenToWorldPoint(MousePosition);
                rb.MovePosition(new Vector2(objPosition.x - offSetX, objPosition.y - offSetY));
            }else if (!inBoundsX)
            {
                rb.MovePosition(new Vector2(-7.5f, objPosition.y - offSetY));
            }
            else if (!inBoundsLowerY)
            {
                rb.MovePosition(new Vector2(objPosition.x - offSetX, -3.4f));
            }
            else if (!inBoundsUpperY)
            {
                rb.MovePosition(new Vector2(objPosition.x - offSetX, 3.4f));
            }
            */
        }
        if (transform.position.x > 7.5 && curState == 0)
        {
            isMouseDragging = false;
            transform.position = new Vector2(12, transform.position.y);
            cam.transform.position = new Vector3(20,0,-10);
            curState++;
        }
        if (transform.position.x > 27.5 && curState == 1)
        {
            isMouseDragging = false;
            transform.position = new Vector2(32, transform.position.y);
            cam.transform.position = new Vector3(40, 0, -10);
            curState++;
        }
        if (currentPhoto == 4) { revealPhotos(); }
    }
    //Done
    public void revealPhotos()
    {
        SceneManager.LoadScene("PhotosRevealed");
        //Allow access to admin
        PlayerPrefs.SetInt("Admin", 1);
    }

    public void NextPhoto()
    {
        completePhoto = false;
        numPhotos--;
        currentPhoto++;
        gameObject.GetComponent<SpriteRenderer>().sprite = allSprites[currentPhoto - 1];
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        gameObject.AddComponent<BoxCollider2D>();
        isMouseDragging = false;
        transform.position = Origin;
        cam.transform.position = new Vector3(0, 0,-10);
        curState = 0;
    }

    public void Reposition()
    {
        if (currentPhoto == 1)
        {
            isMouseDragging = false;
            transform.position = Origin;
            cam.transform.position = new Vector3(0, 0, -10);
            curState = 0;
        }
        //else if (currentPhoto == TotalPhotos) { ToArtsFinished();  }
        else { NextPhoto(); }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {  
        if(collision.collider.tag == "bin")
        {
            Debug.Log("InBin");
            Vector2 ct = collision.collider.transform.position;
            transform.position = new Vector2(ct.x, ct.y + 0.2f);
            isMouseDragging = false;
            if(completePhoto && numPhotos > 0)
            { 
                if (currentPhoto <= numPhotos)
                {
                    NextPhoto();
                }
                else
                {
                    revealPhotos();
                }
            }
            else { completePhoto = true; }
            
        }
    }
}
