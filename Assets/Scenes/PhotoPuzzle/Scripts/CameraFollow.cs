using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // This determines which object the camera will follow
    public string follow_tag = "Player";

    [Range(0, 1)]
    public float follow_speed;
    private Transform target;

    private void Start()
    {
        // find the first GameObject in the scene tagged as follow_tag and assign as target
        target = GameObject.FindGameObjectWithTag(follow_tag).transform;
        Debug.Log(target);
    }

    private void FixedUpdate()
    {
        // Linearly interpolate between camera position and target position, based on value of follow_speed
        Vector2 pos = Vector2.Lerp(transform.position, target.position, follow_speed);
        // Set new camera position, make sure to assign z position behind the game content!
        if (pos.x > 0)
        {
            transform.position = new Vector3(pos.x, transform.position.y, -10.0f);
        }
    }

}