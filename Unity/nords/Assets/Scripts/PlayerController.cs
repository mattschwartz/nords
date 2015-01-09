using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float Speed = 7;
	public float ScrollSpeed = 28;
	public float RotateSpeed = 50;
	public Transform CameraBoom;

	void Update()
	{
		if (Input.GetKey(KeyCode.Q)) {
			CameraBoom.Rotate(new Vector3(0, -RotateSpeed * Time.deltaTime, 0));
		}

		if (Input.GetKey (KeyCode.E)) {
			CameraBoom.Rotate(new Vector3(0, RotateSpeed * Time.deltaTime, 0));
		}

		float hMove = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");
		float yMove = Input.GetAxis("Mouse ScrollWheel");

		var vec = new Vector3(hMove * Speed * Time.deltaTime, 0, vMove * Speed * Time.deltaTime);
		
		CameraBoom.Translate(vec);

		if (Mathf.Abs(yMove) > 0) {
			var rot = Quaternion.Euler(45, 0, 0);
			vec = rot * new Vector3(0, 0, yMove * ScrollSpeed * Time.deltaTime);

			CameraBoom.Translate(vec);
		}
	}
}
