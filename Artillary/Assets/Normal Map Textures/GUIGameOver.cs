using UnityEngine;
using System.Collections;

public class GUIGameOver : MonoBehaviour {

	
	public bool gameover = false;
	float alpha=0;
	void Start () {
		this.guiText.text = "YOU STILL DIE\nFROM RADIATION\nPOISONING.\nNOBODY WINS \nWITH NUKES!";
	}
	
	// Update is called once per frame
	void Update () {
		if(gameover)			
		{
			alpha += 0.01f;
			
		}
		
	
		this.guiText.material.color = new Color(255,0,0,alpha);
	}
}
