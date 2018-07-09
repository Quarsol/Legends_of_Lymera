using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

public Transform target;
public float m_speed = 0.2f;
Camera mycam;

	void Start () {

		mycam = GetComponent<Camera> ();

	}

	void Update () {

		mycam.orthographicSize = (Screen.height / 3f) / 4f;

		if (target) {
			transform.position = Vector3.Lerp(transform.position, target.position, m_speed) + new Vector3(0, 0, -10);
		}

	}
}
