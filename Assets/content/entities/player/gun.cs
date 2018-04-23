using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
    public GameObject bullet;
    public float delay = 0.33f;

    float timestamp;

    void Update() {
        if (Time.time >= timestamp && Input.GetMouseButton(0)) {
            Instantiate(bullet, transform.position, transform.rotation);
            timestamp = Time.time + delay;
        }
    }
}
