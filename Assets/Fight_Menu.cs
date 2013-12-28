using UnityEngine;
using System.Collections;

public class Fight_Menu : MonoBehaviour
{
	
		void OnGUI ()
		{
				// Make a background box
				GUI.Box (new Rect (10, 10, 130, 140), "Action Menu");
		
				if (GUI.Button (new Rect (20, 40, 110, 20), "Physical Attack")) {
						Debug.Log ("Physical Attack");
				}
				if (GUI.Button (new Rect (20, 65, 110, 20), "Magic Attack")) {
						Debug.Log ("Magic Attack");
				}
				if (GUI.Button (new Rect (20, 90, 110, 20), "Wait/Defend")) {
						Debug.Log ("Wait/Defend");
				}
				if (GUI.Button (new Rect (20, 115, 110, 20), "Withdraw")) {
						Debug.Log ("Withdraw");
				}
		}
}
