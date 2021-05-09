using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	public float angle;

	// Use this for initialization
	void OnMouseDrag () {

		float x = Input.GetAxis ("Mouse X");
		transform.RotateAround (transform.position, new Vector3 (0, 1, 0) * Time.deltaTime *-1* x, angle);
		
	}


}
