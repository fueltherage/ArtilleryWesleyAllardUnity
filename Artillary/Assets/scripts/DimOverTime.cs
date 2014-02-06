using UnityEngine;
using System.Collections;

public class DimOverTime : MonoBehaviour {

	public float timeUntilOff = 5;
	float intensity;
	float step;
	void Start () {
		intensity = this.light.intensity;
		step = intensity / timeUntilOff;
	}
	
	
	void Update () {
		if(intensity>0)
		{
			intensity -= step*Time.deltaTime;
		}else if(intensity<0)intensity = 0;
		this.light.intensity = intensity;
	}
}
