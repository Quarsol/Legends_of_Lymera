using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour {

	public void BattleMap() {
		SceneManager.LoadScene(1);
	}

	public void OverWorld(){
		SceneManager.LoadScene(0);
	}
}
