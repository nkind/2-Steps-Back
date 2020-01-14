using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWater : MonoBehaviour
{
    public GameObject waterDrop;
    float fallSpeed = 1.3f;
    float timeLength = 0f;
    float timer;
    //float rainDropAmount; // Was going to make clusters of droplets. Might be too much
    // Start is called before the first frame update
    void Start()
    {
        timer = timeLength;
        //rainDropAmount = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1* Time.deltaTime;
        Vector2 spawnLoc = new Vector2(transform.position.x + Random.Range(-0.5f,0.5f), transform.position.y);
        if(timer <= 0)
        {
            //for (int x = 0; x < rainDropAmount; x++)
            //{
                GameObject water = Instantiate(waterDrop, spawnLoc, Quaternion.identity) as GameObject;
                water.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -2) * fallSpeed);
            //}
            //Rain drops fall randomly
            timer = Random.Range(0.25f,2.25f);
        }
    }
}
