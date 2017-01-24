using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = new Vector3 (0, 0, 10);

	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y))+offset;
		//pos = gameObject.transform.position;

	}
}
