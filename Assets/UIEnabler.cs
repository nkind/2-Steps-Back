using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIEnabler : MonoBehaviour
{

	public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if((Application.loadedLevelName) == "Adminkeypad" ||
			(Application.loadedLevelName) == "PhotosRevealed" ||
			(Application.loadedLevelName) == "Beaker" ||
			(Application.loadedLevelName) == "ComplexRhythmPuzzle" ||
			(Application.loadedLevelName) == "DinoPuzzleA" ||
			(Application.loadedLevelName) == "DinoPuzzleB" ||
			(Application.loadedLevelName) == "DinoPuzzleC" ||
			(Application.loadedLevelName) == "Microscope" ||
			(Application.loadedLevelName) == "ChemicalMixing" ||
			(Application.loadedLevelName) == "PhotoPuzzle" ||
			(Application.loadedLevelName) == "RhythmTapper" ||
			(Application.loadedLevelName) == "KeyPad" ||
			(Application.loadedLevelName) == "Skeleton" ||
			(Application.loadedLevelName) == "MapScene" ||
			(Application.loadedLevelName) == "TitleScene") {
			UI.SetActive(false);
		}
		else {
			UI.SetActive(true);
		}
    }
}
