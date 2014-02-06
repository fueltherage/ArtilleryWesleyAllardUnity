using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public static PlayerScript instance;
	
	public GameObject deathAnimation;

	Vector3 StartingPos;	
	Vector2 Velocity;
	Vector2 Acceleration;

	bool dieing;
	public float DeathCountdown = 5;
	public bool active;	
	public int PlayerHealth = 100;	
	public int PlayerNumber;
	float deathTimer;
	
	void Start () {
		StartingPos = this.transform.position;
		active = true;
		dieing = false;
		instance = this;//Instance is used to call/check vars from outside the class
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(PlayerHealth>0)
		{		
			/*if(this.transform.position.z != StartingPos.z)
			{
				float offset = StartingPos.z - this.transform.position.z;
				this.transform.Translate(0,0,offset);
			}*/
		}else{
			deathTimer += Time.deltaTime;
			if(deathTimer > 10)Application.LoadLevel("Level1");
			if(!dieing)
			{
				dieing = true;
				GameObject death;
				death = Instantiate(deathAnimation, this.transform.position, Quaternion.identity)as GameObject;
				GameObject.FindGameObjectWithTag("GameOver").GetComponent<GUIGameOver>().gameover = true;
				//Destroy(this.transform.parent.gameObject);
			}
		}
	
	}
	void OnCollisionEnter(Collision hit)
	{
		if(hit.gameObject.tag == "Missile")
		{
			PlayerHealth -= 25;
		}
	}
	void OnTriggerEnter(Collider hit)
	{		
		if(hit.gameObject.name == "Nuke3(Clone)")
		{//Staggered Hit, Half Damage
			PlayerHealth -= 10;
		}else if(hit.gameObject.tag == "Explosion")
		{
			PlayerHealth -= 10;
		}
	}
	
}
