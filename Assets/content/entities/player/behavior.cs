using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour {
    public Camera mainCamera;
    public GameObject bullet;
    public float delay = 0.33f;
    public float speed = 0.1f;

    float timestamp;

    void Update() {
        if (Time.time >= timestamp && Input.GetMouseButton(0)) {
            Instantiate(bullet, transform.position, transform.rotation);
            timestamp = Time.time + delay;
        }
    }

    void FixedUpdate() {
       this.transform.Translate(
            Input.GetAxis("Horizontal")*speed,
            Input.GetAxis("Vertical")*speed,
            0
            );
    }
}
