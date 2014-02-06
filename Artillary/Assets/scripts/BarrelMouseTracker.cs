using UnityEngine;
using System.Collections;

public class BarrelMouseTracker : MonoBehaviour {

	// Use this for initialization
	public GameObject Player;
	Vector3 currentMousePosOnScreen;
	Vector3 currentMousePosWorld;
	Vector3 centerScreen;
	void Start () {
		
	}
	
	void Update () {
		if(Player.GetComponent<PlayerScript>().active)
		{
				
			currentMousePosOnScreen = Input.mousePosition;
			
			centerScreen.x = Screen.width/2.0f;
			centerScreen.y = Screen.height/2.0f;
			centerScreen.z = 0;
			
			currentMousePosWorld = currentMousePosOnScreen - centerScreen; 
			
			
			
			//Debug.Log("Mouse Pos"+ currentMousePosWorld);
			this.transform.LookAt(currentMousePosWorld+this.transform.position);
		}
	
	}
}
