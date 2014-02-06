using UnityEngine;
using System.Collections;

public class RotatingBackground : MonoBehaviour {

	// Use this for initialization
	public float time=45;
	public float speed = 0.05f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(0,0,speed);	
	
	}
}
