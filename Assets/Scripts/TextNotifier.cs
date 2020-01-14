using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextNotifier : MonoBehaviour
{

	public GameObject textNotification1;
	public GameObject textNotification2;
	public GameObject textNotification3;

	protected bool firstVisitChem = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (firstVisitChem == false) {
			if (SceneManager.GetActiveScene().name == "ChemistryLobby") {
				firstVisitChem = true;
				textNotification1.SetActive(true);
				textNotification2.SetActive(true);
				textNotification3.SetActive(true);
			}
		}
    }
}
