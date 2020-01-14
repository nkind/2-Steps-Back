using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfActive : MonoBehaviour
{

	//public GameObject DNASample;
	public GameObject chemLobbyEntryText; // Display text when entering Chem for first time
	public GameObject textEntryPointDNA; // Display text after swabbing the body in Chem
	public GameObject DNATextWin; // Display text after winning DNA puzzle
	public GameObject DNATextConclusion; // Final text of conversation after winning DNA Puzzle
	public GameObject textEntryPointChemMix; // Display text after collecting all Recipe Scraps
	public GameObject ChemMixTextWin; // Display text after winning Chemical Mixing puzzle

	protected bool textEntryPointDNAController = false; // global flag to see if entry button has been clicked
	protected bool textEntryPointChemMixController = false; // global flag to see if entry button has been clicked

    public void Update()
    {
		if ((chemLobbyEntryText.activeInHierarchy == false) && ((Application.loadedLevelName) == "ChemistryLobby")) {
			chemLobbyEntryText.SetActive(true);
		}

		//if (clue.activeInHierarchy == true) {
		if (PlayerPrefs.GetInt("DNASample") == 1) {
			if (textEntryPointDNAController == false) {
				Debug.Log("It is false");
				textEntryPointDNAController = true;
				textEntryPointDNA.SetActive(true);
			}
    	}

		if (PlayerPrefs.GetInt("Score") >= 5000) {
			textEntryPointDNA.SetActive(false);
			DNATextWin.SetActive(true);
		}

		if (PlayerPrefs.GetInt("Recipe Scrap 1") == 1 &&
			PlayerPrefs.GetInt("Recipe Scrap 2") == 1 &&
			PlayerPrefs.GetInt("Recipe Scrap 3") == 1 &&
			DNATextConclusion.activeInHierarchy == true) {
			if (textEntryPointChemMixController == false) {
				textEntryPointChemMixController = true;
				textEntryPointChemMix.SetActive(true);
			}
		}

		if (PlayerPrefs.GetInt("ChemPass") == 1) {
			textEntryPointChemMix.SetActive(false);
			ChemMixTextWin.SetActive(true);
		}
    }
		
}
