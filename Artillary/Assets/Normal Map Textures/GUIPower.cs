using UnityEngine;
using System.Collections;

public class GUIPower : MonoBehaviour {

	// Use this for initialization
	public GameObject Gun1;
	public GameObject Gun2;
	void Start () {
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Gun1.GetComponent<Shoot>().Player.GetComponent<PlayerScript>().active)
		{
			this.guiText.text = "Power: "+Gun1.GetComponent<Shoot>().power;
		}
		
		if(Gun2.GetComponent<Shoot>().Player.GetComponent<PlayerScript>().active)
		{
			this.guiText.text = "Power: "+Gun2.GetComponent<Shoot>().power;
		}
	}
}
