using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhonePuzzleEnable : MonoBehaviour
{

	public GameObject enableDNAPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (PlayerPrefs.GetInt("DNASample") == 1) {
			enableDNAPuzzle.SetActive(true);
		}
    }
}
