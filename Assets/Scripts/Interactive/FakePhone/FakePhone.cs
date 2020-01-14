using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakePhone : MonoBehaviour
{
    public void GotoPhone()
    {
        SceneManager.LoadScene("FakePhoneScene");
    }

    private void Start()
    {
        
    }
}
