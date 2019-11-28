using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWalk : MonoBehaviour {

	public float speed=2.0f;
	public bool move;
	public float togAngle=19.0f;
	public Transform cam;
	private CharacterController cc;

	// Use this for initialization
	void Start () {
	
		cc=GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

		if (cam.eulerAngles.x < 90.0f && cam.eulerAngles.x > togAngle) {
		
			move = true;
		} else {
			move = false;
		}

		if (move) {
			Vector3 forward= cam.TransformDirection(Vector3.forward);
			cc.SimpleMove(forward*speed);
		
		}
		
	}
}
