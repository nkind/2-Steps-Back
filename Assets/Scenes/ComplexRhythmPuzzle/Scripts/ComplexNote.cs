using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexNote : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;

    public GameObject viewBlocker;
    public GameObject[] activators;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start() {
        rb.velocity = new Vector2(0, -speed);
    }

    public void MysteryEffect() {
        int rand = Random.Range(0, 100) % 4;

        switch (rand) {
            case 0:
                StartCoroutine("BlockView");
                break;
            case 1:
                StartCoroutine("SlowMotion");
                break;
            case 2:
                StartCoroutine("FastMotion");
                break;
            case 3:
                StartCoroutine("WideActivators");
                break;
        }
    }

    public IEnumerator BlockView() {
        viewBlocker.SetActive(true);
        yield return new WaitForSeconds(2f);
        viewBlocker.SetActive(false);
    }

    private IEnumerator SlowMotion() {
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds(2);
        Time.timeScale = 1f;
    }

    private IEnumerator FastMotion() {
        Time.timeScale = 1.4f;
        yield return new WaitForSeconds(3);
        Time.timeScale = 1f;
    }
    
    private IEnumerator WideActivators() {
        foreach (GameObject activator in activators) {
            activator.transform.localScale += new Vector3(0, 0.3f, 0);
        }
        yield return new WaitForSeconds(2);
        foreach (GameObject activator in activators) {
            activator.transform.localScale -= new Vector3(0, 0.3f, 0);
        }    
    }


    IEnumerator DelayedDestoryEnum() {
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    private void DelayedDestroy() {
        StartCoroutine("DelayedDestoryEnum");
    }
}
