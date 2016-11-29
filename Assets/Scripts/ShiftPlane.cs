using UnityEngine;
using System.Collections;

public class ShiftPlane : MonoBehaviour {
	public float xSpeed = 0;
	public float zSpeed = 0;

	public float maxXOffset = 0;
	public float minXOffset = 0;

	public float maxZOffset = 0;
	public float minZOffset = 0;

	public int xDirection = 1;
	public int zDirection = 1;

	private float startX;
	private float startZ;

	// Use this for initialization
	void Start () {
		startX = transform.position.x;
		startZ = transform.position.z;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < startX + minXOffset) {
			xDirection = 1;
		} else if (transform.position.x > startX + maxXOffset) {
			xDirection = -1;
		}

		if (transform.position.z < startZ + minZOffset) {
			zDirection = 1;
		} else if (transform.position.z > startZ + maxZOffset) {
			zDirection = -1;
		}

		Vector3 offset = new Vector3(xSpeed * xDirection, 0, zSpeed * zDirection);

		transform.position = transform.position + offset;
	}
}
