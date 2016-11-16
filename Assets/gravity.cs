using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {
	private const float		GRAVITY = 200.0f; //重力
	private CharacterController	charaCon;
	private Vector3 move = Vector3.zero;
	private float speed = 20.0f;
	float rx,ry,rz;


	void Start () {
		charaCon = GetComponent< CharacterController > ();	
	}
	
	// Update is called once per frame
	void Update () {
		float y = move.y;
		rx += Random.Range(-0.5f,0.5f);
		ry += Random.Range(-0.5f,0.5f);
		rz += Random.Range(-0.5f,0.5f);
		move = new Vector3 (Input.GetAxis ("Horizontal"), 0.0f, Input.GetAxis ("Vertical"));
		move *= speed;
		move.y = y;

		if (transform.position.y > 310.0f&& transform.position.y < 800.0f) {
			move.y = -80;
			move.y += 0.5f;
		} 
		move.y -= 1;

		charaCon.Move (move * Time.deltaTime);
	}
}
