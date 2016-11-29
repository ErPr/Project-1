using UnityEngine;
using System.Collections;

public class RotatePlane : MonoBehaviour {
	public float speedOfRotation;
	public float minAngle;
	public float maxAngle;
	public int direction = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xAngle = transform.eulerAngles.x;
		if (xAngle < (360 + minAngle) && xAngle > 180) {
			direction = 1;
		}

		if (xAngle < 180 && xAngle > maxAngle) {
			direction = -1;
		}
		Vector3 rotation = new Vector3();
		rotation.x = direction * speedOfRotation;

		Vector3 newAngle = new Vector3 (xAngle + direction * speedOfRotation, 0, 0);
		transform.eulerAngles = newAngle;

	}
}
