using UnityEngine;
using System.Collections;

public class StateTracker : MonoBehaviour {

	// Use this for initialization
	public static StateTracker instance;
	public enum Turn{ Player1, Player2, Player3, Player4 };
	
	public Turn currentTurn;
	
	void Start () {
		//The instance var is used to access vars inside of this class;
		instance = this;
		
		//Decide who goes first with a random number
		switch(Random.Range(1,4))
		{
		case 1:
			currentTurn = Turn.Player1;	
			break;
		case 2:
			currentTurn = Turn.Player2;	
			break;
		case 3:
			currentTurn = Turn.Player3;	
			break;
		case 4:
			currentTurn = Turn.Player4;	
			break;			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
