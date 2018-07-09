using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour {

	public static int whichTurn = 1;

	public enum BattleState {
		Start,
		PlayerChoice,
		Win
	}

	private BattleState CurrentState;

	void Start () {
		CurrentState = BattleState.Start;
	}

	void Update () {
		switch(CurrentState) {
			case(BattleState.Start) :
				break;
			case(BattleState.PlayerChoice) :
				break;
			case(BattleState.Win) :
				break;
		}

	}
}
