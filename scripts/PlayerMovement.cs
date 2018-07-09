using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public Rigidbody2D rbody;
	public Animator anim;
	public int speed = 100;


	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Update () {
		MovePos();

}

void MovePos(){

	Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		if (movement_vector != Vector2.zero) {
			anim.SetBool("isWalking", true);
			anim.SetFloat("input_x", movement_vector.x);
			anim.SetFloat("input_y", movement_vector.y);

		} else {
			anim.SetBool("isWalking", false);
		}

		rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime * speed);

	}
}
