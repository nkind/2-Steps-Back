using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* DESCRIPTION:
 * PhoneTextController is a script that handles a
 * number of aspects related to the Phone UI, such
 * as making text responses appear after a specified
 * delay or making response option buttons appear.
 * These components are specified within the editor.
 * 
 * USAGE:
 * - attach script to button in Phone UI (i.e your own text response)
 * - specify the time for the npc's text response to be delayed by (if applicable)
 * - specify the text response to enable (if applicable)
 * - specify the first response option button to enable (if applicable)
 * - specify the second response option button to enable (if applicable)
 */

public class PhoneTextController : MonoBehaviour
{
	public float delayTime; // Used to delay the arrival of a text (after sending yours) by delayTime seconds
	public GameObject responseToEnable; // The button to enable that contains the received text (if applicable)
	public GameObject convoButtonResponse1; // Option 1 to respond with (if applicable)
	public GameObject convoButtonResponse2; // Option 2 to respond with (if applicable)

    public void Start()
    {
		StartCoroutine(pause());
    }

	IEnumerator pause() {
		yield return new WaitForSeconds(delayTime);

		if (responseToEnable != null) {
			responseToEnable.SetActive(true);
		}

		if (convoButtonResponse1 != null) {
			convoButtonResponse1.SetActive(true);
		}

		if (convoButtonResponse2 != null) {
			convoButtonResponse2.SetActive(true);
		}
	}
}
