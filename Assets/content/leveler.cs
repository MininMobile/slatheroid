using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveler : MonoBehaviour {
    public GameObject block;
    public string level;

	void Start() {
        if (block == null) throw new System.NullReferenceException("Didn't specify wall prefab for leveler.cs");
        if (level == null) throw new System.NullReferenceException("Didn't specify json level for leveler.cs");

        LoadLevel(level);
	}
    
    void LoadLevel(string level) {
        // do shit to load a level
    }
}
