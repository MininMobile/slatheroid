using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
    public float delay = 0.33f;

    float timestamp;

    void Update() {
        Vector2 direction = Vector2.left;
        RaycastHit2D ray = Physics2D.Raycast(transform.position, direction);
        Debug.DrawRay(transform.position, direction);


        /*if (Time.time >= timestamp && Input.GetMouseButton(0)) {
            
            
            timestamp = Time.time + delay;
        }*/
    }
}
