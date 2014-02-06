using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	
	public Rigidbody bullet;
	public GameObject Player;
	float basePower = 300;
	public float power;
	public bool missileLaunched;
	
	void Start () {
		power = basePower;
		missileLaunched = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.GetComponent<PlayerScript>().active && !missileLaunched)
		{
			if(Input.GetMouseButton(0))
			{	
				 
				if(power < 4000)
				{
					power += 20;
				}if(power > 4000)
				{
					power = 4000;
				}
			}
			if(Input.GetMouseButtonUp(0))
			{
				missileLaunched = true;
				shootBullet();
			}
		}
	}
	void shootBullet()
	{
		Rigidbody clone = Instantiate(bullet, this.transform.position, Quaternion.identity)as Rigidbody;
		clone.AddForce(this.transform.forward * power, ForceMode.Force);
		Camera.main.GetComponent<CameraXY>().lookingAt = clone.gameObject;
		power = basePower;
	}
}
