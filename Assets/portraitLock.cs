using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portraitLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Screen.autorotateToPortrait = true;
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
