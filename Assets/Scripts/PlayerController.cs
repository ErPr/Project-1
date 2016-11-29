using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
    public float jump;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse); ;
        }
        Vector3 movement = new Vector3 (moveVertical, 0.0f, -1 * moveHorizontal);

		rb.AddForce (movement * speed);
	}
}