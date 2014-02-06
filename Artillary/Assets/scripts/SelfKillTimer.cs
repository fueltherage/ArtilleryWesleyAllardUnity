using UnityEngine;
using System.Collections;

public class SelfKillTimer : MonoBehaviour {

	// Use this for initialization
	public float TimeUntilDeath=0;
	void Start () {
		Destroy(this.gameObject, TimeUntilDeath);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
