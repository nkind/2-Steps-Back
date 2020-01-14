using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonSafe : MonoBehaviour {
    // Start is called before the first frame update
    public void ResetLevel() {
        Application.LoadLevel(0);       
    }

}
