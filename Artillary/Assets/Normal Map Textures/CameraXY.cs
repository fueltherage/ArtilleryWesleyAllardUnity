using UnityEngine;
using System.Collections;

public class CameraXY : MonoBehaviour {

	// Use this for initialization
	public GameObject defaultPos;
	public GameObject gameMasterGO;
	public GameObject lookingAt;
	Vector2 difference;
	void Start () {
		lookingAt = defaultPos;
	}
	
	// Update is called once per frame
	void Update () {

		if(lookingAt == null)
		{
			lookingAt = defaultPos;
		}
		difference = new Vector2(lookingAt.transform.position.x - this.transform.position.x, 
								lookingAt.transform.position.y - this.transform.position.y);
		
		this.transform.Translate(difference.x, difference.y, 0);
	
	}
	public void DefaultPos()
	{
		lookingAt = defaultPos;
	}
}
