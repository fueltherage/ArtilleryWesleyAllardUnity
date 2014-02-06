using UnityEngine;
using System.Collections;

public class NukeScript : MonoBehaviour {

	// Use this for initialization
	public float NukeHeadSpeed = 10f;
	
	public float LifeTimeAnimation=1;
	 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0,NukeHeadSpeed*Time.deltaTime,0, Space.World);
	
	}
}
