using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Morgue : MonoBehaviour {
    public Sprite skeletonlessMorgue;
    private Image m_Image;

    private void Start()
    {
        m_Image = GetComponent<Image>();
        if (PlayerPrefs.GetInt("SolvedSkeleton") == 1)
        {
            m_Image.sprite = skeletonlessMorgue;
        }
    }
    // Update is called once per frame
    void Update() {
        if(PlayerPrefs.GetInt("SolvedSkeleton") == 1) {
            m_Image.sprite = skeletonlessMorgue;
        }
    }
}
