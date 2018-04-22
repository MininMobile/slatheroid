using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveler : MonoBehaviour {
    public GameObject _player;
    public GameObject _block;
    public List<TextAsset> _levels;
    public int _lvl;

    List<GameObject> prefabs = new List<GameObject> { };

    void Start() {
        if (_block == null)
            throw new System.NullReferenceException("Didn't specify wall prefab for leveler.cs");
        if (_levels == null)
            throw new System.NullReferenceException("Didn't specify json level for leveler.cs");

        LoadLevel(_levels, _lvl);
	}

    void LoadLevel(List<TextAsset> levels, int lvl = 0) {
        var level = JsonUtility.FromJson<LevelType>(levels[lvl].ToString());

        if (level.level.ToArray().Length / level.width != Mathf.Round(level.level.ToArray().Length / level.width))
            throw new System.IndexOutOfRangeException("Specified level has incorrect amount of lines");

        while (prefabs.ToArray().Length >= 1) {
            Destroy(prefabs[0]);
            prefabs.Remove(prefabs[0]);
        }

        double h;
        double v;

        var line = 0;
        var lineProgress = 0;
        for (var i = 0; i < level.level.ToArray().Length; i++) {
            lineProgress++;
            
            switch (level.level[i]) {
                case "0":
                    break;
                case "1":
                    var prefab = Instantiate(_block);
                    v = line * 0.64;
                    h = lineProgress * 0.64;
                    prefab.transform.Translate((float)h, (float)-v, 1);
                    break;
                case "s":
                    v = line * 0.64;
                    h = lineProgress * 0.64;
                    _player.transform.Translate((float)h, (float)-v, 1);
                    break;
            }

            if (lineProgress == level.width) {
                line++;
                lineProgress = 0;
            }
        }
    }
}
