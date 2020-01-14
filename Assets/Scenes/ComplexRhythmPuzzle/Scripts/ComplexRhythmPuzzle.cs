using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexRhythmPuzzle : MonoBehaviour {
    public void OrientationLeft() {
        Screen.autorotateToLandscapeLeft = true;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    
    public void OrientationPortrait() {
        Screen.autorotateToPortrait = true;
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
