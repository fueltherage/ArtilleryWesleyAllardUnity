using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	
	public int StartingPlayer=1;
	public int currentPlayer;
	
	public GameObject Player1;
	public GameObject Player2;	
	
	void Start () {
		
		currentPlayer = StartingPlayer;
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel("Level1");
		}
		
		if(currentPlayer == 1)
		{
			Player1.GetComponent<PlayerScript>().active = true;
			
			Player2.GetComponent<PlayerScript>().active = false;
		}if(currentPlayer == 2)
		{
			Player1.GetComponent<PlayerScript>().active = false;
			
			Player2.GetComponent<PlayerScript>().active = true;
		}
	
	}
	public void NextTurn()
	{
		if(currentPlayer == 1)
		{
			currentPlayer++;
			Player2.transform.parent.GetComponentInChildren<Shoot>().missileLaunched = false;
			
		}else if(currentPlayer == 2){
			Player1.transform.parent.GetComponentInChildren<Shoot>().missileLaunched = false;
			currentPlayer--;
			
		}
		Debug.Log("Player "+currentPlayer+"'s turn");
	}
	public GameObject currentPlayerTurn()
	{
		if(currentPlayer ==1)
		{
			return Player1;
		}
		if(currentPlayer ==2)
		{
			return Player2;
		}
		return Player1;
	}
}

