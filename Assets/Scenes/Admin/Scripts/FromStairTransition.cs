using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromStairTransition : MonoBehaviour
{
    public void LoadArea(string area)
    {
        SceneManager.LoadScene(area);
    }
}
