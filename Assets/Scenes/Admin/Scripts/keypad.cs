using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{

    public string psw = "";
    public string rightpsw = "ANIMO";
    public GameObject hint;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        handleKeyPress();
    }

    public void handleKeyPress()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                string key = hit.transform.gameObject.name;
                switch (key)
                {
                    case "O_up":
						gameObject.GetComponent<Animator>().SetBool("isOPressing", true);
                        psw = psw + "O";
                        break;
                    case "D_up":
                        gameObject.GetComponent<Animator>().SetBool("isDPressing", true);
                        psw = psw + "D";
                        break;
                    case "M_up":
                        gameObject.GetComponent<Animator>().SetBool("isMPressing", true);
                        psw = psw + "M";
                        break;
                    case "T_up":
                        gameObject.GetComponent<Animator>().SetBool("isTPressing", true);
                        psw = psw + "T";
                        break;
                    case "S_up":
                        gameObject.GetComponent<Animator>().SetBool("isSPressing", true);
                        psw = psw + "S";
                        break;
                    case "A_up":
                        gameObject.GetComponent<Animator>().SetBool("isAPressing", true);
                        psw = psw + "A";
                        break;
                    case "R_up":
                        gameObject.GetComponent<Animator>().SetBool("isRPressing", true);
                        psw = psw + "R";
                        break;
                    case "I_up":
                        gameObject.GetComponent<Animator>().SetBool("isIPressing", true);
                        psw = psw + "I";
                        break;
                    case "N_up":
                        gameObject.GetComponent<Animator>().SetBool("isNPressing", true);
                        psw = psw + "N";
                        break;
                    case "lock_up":
                        gameObject.GetComponent<Animator>().SetBool("isLockPressing", true);

                        if (psw == rightpsw)
                        {
                            Debug.Log("pass!!!");
                            gameObject.GetComponent<Animator>().SetBool("pass", true);
                            UnityEngine.SceneManagement.SceneManager.LoadScene("Staircase");
                        }
                        else
                        {
                            Debug.Log("nonono!!!" + psw + "vs." + rightpsw);
                            StartCoroutine(redFlash());
                            psw = "";
                            hint.SetActive(true);

                        }
                        break;
                }
            }

        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("isOPressing", false);
            gameObject.GetComponent<Animator>().SetBool("isDPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isMPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isTPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isSPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isRPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isIPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isAPressing", false);
			gameObject.GetComponent<Animator>().SetBool("isNPressing", false);
            gameObject.GetComponent<Animator>().SetBool("isLockPressing", false);
        }
    }
    IEnumerator redFlash() {
        gameObject.GetComponent<Animator>().SetBool("wrong", true);
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Animator>().SetBool("wrong", false);
    }
}
