using System.Collections.Generic;
using UnityEngine;

public class BattleWarp : MonoBehaviour {

	public Transform warpTarget;
	public SceneHandler scene;
	// private Vector3 playerPOS;

	void Start () {
		 scene = GameObject.Find("GM").GetComponent<SceneHandler>();
	}

	IEnumerator OnTriggerEnter2D(Collider2D other) {

		ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();

		yield return StartCoroutine (sf.FadeToBlack ());

		if (other.name == "PC"){
			StartFight();
		}

		// playerPOS = GameObject.Find("PC").transform.position;

		scene.BattleMap();



	}

	void StartFight() {
		Destroy(GameObject.Find("Enemy"));
	}

}
