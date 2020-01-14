using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCloseDisablerEnabler : MonoBehaviour
{

/* DESCRIPTION:
 * PhoneCloseDisablerEnabler is a script that
 * enables/disables the close button of the
 * phone UI. This is to prevent the player
 * from closing the texting interface when
 * the technician is sending a response back.
 * Without this, if the player were to close
 * the phone before the technician sends his
 * reply, his response is never received,
 * resulting in a softlock and preventing
 * further progress.
 * 
 * USAGE:
 * - attach script to button in Phone UI (the text you
 *   send, if there is a response to be received)
 * - reference for "closeButton" object will be the following:
 *   UI Canvas => Contact Conversations => Technician => Top Bar => Button
 * - reference for receivedText will be what the technician's response will be
 */

	public GameObject closeButton;
	public GameObject receivedText;

	public void Update() {
		if (receivedText.activeInHierarchy == false) {
			closeButton.SetActive(false);
		}
		else {
			closeButton.SetActive(true);
		}
	}
}
