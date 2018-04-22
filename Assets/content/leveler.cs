using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveler : MonoBehaviour {
    public GameObject _block;
    public List<TextAsset> _levels;
    public int _lvl;

    List<GameObject> prefabs = new List<GameObject> { };

    void Start() {
        if (_block == null)
            throw new System.NullReferenceException("Didn't specify wall prefab for leveler.cs");
        if (_levels == null)
            throw new System.NullReferenceException("Didn't specify json level for leveler.cs");
	}
    
    void LoadLevel(List<TextAsset> levels, int lvl = 0) {
        var level = JsonUtility.FromJson<LevelType>(levels[lvl].ToString());

        if (level.level.ToArray().Length/level.width != Mathf.Round(level.level.ToArray().Length/level.width))
            throw new System.IndexOutOfRangeException("Specified level has incorrect amount of lines");
    }
}
