using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    int count;

    float time;
    private float MaxDubbleTapTime = 0.45f;

    public void Update()
    {
                    if (Input.touchCount == 1)
                    {
                        Touch touch = Input.GetTouch(0);
                        if (touch.phase == TouchPhase.Ended)
                        {
                            count += 1;
                        }
                        if (count == 1)
                        {
                            time = Time.time + MaxDubbleTapTime;
                        }
                        else if (count == 2 && Time.time < time)
                        {
                
                    
                    
                        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                        Vector2 touchPos = new Vector2(wp.x, wp.y);
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && Input.GetTouch(0).phase == TouchPhase.Began)
                        {   
                            float rotation = transform.rotation.eulerAngles.z % 360;
                            if (rotation > 20 && rotation < 340) {
                                gameObject.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z - 90));
                                count = 0;
                            }
                           
                        }
                    
                            
                        }
                        if (Time.time > time)
                        {
                            count = 0;
                        }
                    }
                }
            }
        
        //if (Input.touchCount == 1 && end == true)
        //{
        //    if (Input.GetTouch(0).phase == TouchPhase.Began)
        //    {
        //        this.gameObject.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z - 90));

        //    }
        //    if (Mathf.Abs(transform.position.x - piecePlace.position.x) <= 1f &&
        //                Mathf.Abs(transform.position.y - piecePlace.position.y) <= 1f && Mathf.Abs(0 - transform.rotation.eulerAngles.z) < 30 && Mathf.Abs(0 - transform.rotation.eulerAngles.z) > -10)
        //    {
        //        end = false;

        //    }

        //}

