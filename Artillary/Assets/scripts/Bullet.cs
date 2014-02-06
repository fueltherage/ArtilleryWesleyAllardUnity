using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	public GameObject DeathEffect;
	bool dieing;
	void Start () {
		dieing = false;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(this.transform.rigidbody.velocity + this.transform.position);
		if(Input.GetKeyDown(KeyCode.Space) && !dieing)
		{
			KillBullet();
		}
	}
    void OnCollisionEnter(Collision hit)
    {
		if(!dieing)
		{
			KillBullet();
		}
    }
	void KillBullet()
	{
		dieing=true;
		GameObject explosion;
		explosion = Instantiate(DeathEffect,this.transform.position, Quaternion.identity) as GameObject;
		
		GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>().NextTurn();
		Destroy(this.gameObject, 2);
		
		Destroy(GetComponent<SphereCollider>());
		transform.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	}

}
