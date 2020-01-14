using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* DESCRIPTION:
 * ShiftScrollbar is a script that will move
 * the vertical scrollbar of the Phone UI to
 * a specified position upon receiving a text
 * 
 * NOTE:
 * The shift value is to be specified by
 * a float value ranging from 0.0 to 1.0
 * 
 * USAGE:
 * - attach script to button in Phone UI
 * - set "On-Click" command, reference to same button
 * - Dropdown => PhoneSceneTransitioner => changeScene (string)
 * - fill in field with appropriate name matching the same as
 *   "myNewScene.unity" (do not include file extension in name)
 */


public class ShiftScrollbar : MonoBehaviour
{
	public ScrollRect _sRect; // The scroll view
	public float value; // Value where to place view of vertical scrollbar. Specified in editor
	private int control = 0; // Used to run function once (as per FixedUpdate value from physics engine)

	public void FixedUpdate() {
		if (control < 1) {
			control++;
			scroll();
		}
	}

	public void scroll()
	{
		//_sRect.verticalScrollbar.value = value;
		Debug.Log("Code got here");
		_sRect.verticalNormalizedPosition = value;
		//Canvas.ForceUpdateCanvases();
	}
}
