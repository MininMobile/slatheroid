using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour {
    public GameObject player;
    public float speed = 0.1f;

    void Update() {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        player.transform.SetPositionAndRotation(this.transform.position, Quaternion.AngleAxis(angle+180, Vector3.forward));
    }

    void FixedUpdate() {
        this.transform.Translate(
                Input.GetAxis("Horizontal") * speed,
                Input.GetAxis("Vertical") * speed,
                0
                );
    }
}
