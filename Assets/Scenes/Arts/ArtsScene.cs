using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArtsScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PhotoPuzzle()
    {
        SceneManager.LoadScene("PhotoPuzzle");
    }
    public void PuzzleFinished()
    {
        SceneManager.LoadScene("Arts_PuzzleFinished");
    }
    public void PhotoReveal()
    {
        SceneManager.LoadScene("PhotosRevealed");
    }
}
