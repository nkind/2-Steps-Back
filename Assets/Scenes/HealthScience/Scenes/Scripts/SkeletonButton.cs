using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonButton : MonoBehaviour {
    void Update() {
        if(PlayerPrefs.GetInt("SolvedSkeleton") == 1) {
            gameObject.SetActive(false);
        }
    }
}
