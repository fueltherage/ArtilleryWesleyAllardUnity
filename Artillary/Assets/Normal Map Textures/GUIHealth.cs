using UnityEngine;
using System.Collections;

public class GUIHealth : MonoBehaviour {
	
	
	public GameObject player;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text = "HP: "+player.GetComponent<PlayerScript>().PlayerHealth;
	
	}
}
