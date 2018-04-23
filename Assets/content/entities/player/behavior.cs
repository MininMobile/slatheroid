using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour {
    public Camera mainCamera;
    public GameObject player;
    public GameObject bullet;
    public float delay = 0.33f;
    public float speed = 0.1f;

    float timestamp;

    void Update() {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        player.transform.SetPositionAndRotation(this.transform.position, Quaternion.AngleAxis(angle+180, Vector3.forward));

        if (Time.time >= timestamp && Input.GetMouseButton(0)) {
            Instantiate(bullet, transform.position, transform.rotation);
            timestamp = Time.time + delay;
        }
    }

    void FixedUpdate() {
        this.transform.Translate(
                Input.GetAxis("Horizontal") * speed,
                Input.GetAxis("Vertical") * speed,
                0
                );
    }
}
