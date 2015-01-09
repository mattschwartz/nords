using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour 
{
	public float RotationSpeed = 7;

	void Start()
	{
		gameObject.SetActive(false);
	}

	void FixedUpdate () 
	{
		transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
	}

	public void SetSelectedObject(GameObject other)
	{
		if (other == null) {
			gameObject.SetActive(false);
			return;
		}
		
		gameObject.SetActive(true);
		Vector3 newPos = other.transform.position;

		do {
			newPos.y += 0.1f;
			transform.position = newPos;
		} while (Physics.OverlapSphere(transform.position, 1).Length > 0);
	}
}
