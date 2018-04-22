using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour {
    public float speed = 0.1f;

    void FixedUpdate() {
       this.transform.Translate(
            Input.GetAxis("Horizontal")*speed,
            Input.GetAxis("Vertical")*speed,
            0
            );
	}
}
