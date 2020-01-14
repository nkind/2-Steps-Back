using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdminUses : MonoBehaviour
{
    public void KeyPadLoad()
    {
        SceneManager.LoadScene("Adminkeypad");
    }
    public void KeyPadBack()
    {
        SceneManager.LoadScene("Admin");
    }
    public void Final()
    {
        SceneManager.LoadScene("AdminFinal");
    }
}
