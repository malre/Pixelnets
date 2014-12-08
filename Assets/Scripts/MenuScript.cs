using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public GUIStyle customButton;

	// Use this for initialization
	void OnGUI()
		{

			const int buttonWidth = 104;
			const int buttonHeight = 60;
		    

			// Determine the button's place on screen
			// Center in X, 2/3 of the height in Y
			Rect buttonRect = new Rect(
				Screen.width / 3 - (buttonWidth / 2),
				(2 * Screen.height / 3) - (buttonHeight / 2),
				buttonWidth,
				buttonHeight
				);
		Rect buttonRect2 = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
			
			// Draw a button to start the game
		if(GUI.Button(buttonRect,"Commencer !"))
			{
				// On Click, load the first level.
				// "Stage1" is the name of the first scene we created.
				Application.LoadLevel("Scene");
			}
		if(GUI.Button(buttonRect2,"Aide !"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Aide");
		}
		}
	}

