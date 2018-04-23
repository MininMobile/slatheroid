using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float distance = 5f;
    public float drag = 0.5f;

	void FixedUpdate() {
        this.transform.Translate(0, distance, 0);
        distance -= drag;

        if (distance <= 0) Destroy(this);
	}
}
