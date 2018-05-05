using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
    public float delay = 0.33f;
    public GameObject bullet;

    float timestamp;

    void Update() {
        if (Time.time >= timestamp && Input.GetMouseButton(0)) {
            var b = Instantiate(bullet, transform.position, transform.rotation);
            b.transform.Rotate(0, 0, 90);

            timestamp = Time.time + delay;
        }
    }
}
