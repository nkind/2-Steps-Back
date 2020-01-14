using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* DESCRIPTION:
 * PhoneSceneTransitioner is a script that will change
 * the currently loaded scene (to one that is specified)
 * when texting the Technician to assist with a puzzle
 * to the scene that contains the puzzle.
 * 
 * NOTE:
 * The name of the scene to load must be specified
 * EXACTLY as it is named, else an error will occur
 * during gameplay. The compiler will not catch the
 * error when attempting to play or build the game,
 * as the parameter is being passed as a text field
 * and Unity has no way to cross-check if the value
 * is correct. This field will be filled in the entry
 * field in the editor for whichever button this
 * script is tied to.
 * 
 * USAGE:
 * - attach script to button in Phone UI
 * - set "On-Click" command, reference to same button
 * - Dropdown => PhoneSceneTransitioner => changeScene (string)
 * - fill in field with appropriate name matching the same as
 *   "myNewScene.unity" (do not include file extension in name)
 */


public class PhoneSceneTransitioner : MonoBehaviour
{
    public void changeScene(string sceneName)
    {
		Application.LoadLevel(sceneName);
    }
}
