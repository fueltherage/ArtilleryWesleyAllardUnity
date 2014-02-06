using UnityEngine;
using System.Collections;

public class LightDamp : MonoBehaviour {

	// Use this for initialization
	public float time=45;
	public float speed = 0.05f;
	float intensity;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += speed;
		
		
		
		//if(intensity > 1 ) intensity = 1;
		
		intensity = Mathf.Sin((time/180)*Mathf.PI);
		
		if(intensity < 0.1f){intensity = 0.1f;}
		if(intensity > 1){intensity = 1;}
		
		this.light.intensity = intensity;
		//Debug.Log("Intensity: "+this.light.intensity);
		
		
	}
}
