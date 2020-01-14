using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HSPhoneEntry : MonoBehaviour
{

	public bool sendText = false;

    // Start is called before the first frame update
    void Start()
    {
		Scene currentScene = SceneManager.GetActiveScene ();

		string sceneName = currentScene.name;

		if (sceneName == "Main Lobby")
			sendText = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
