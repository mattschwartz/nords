using UnityEngine;
using System.Collections;

public class BouncyText : MonoBehaviour 
{
	public float BounceSpeed = 0.75f;
	public float MaxDistance = 0.5f;

	private bool FloatUp = true;
	private float Distance = 0;
	
	void Update () 
	{
		Distance += Time.deltaTime;

		if (Distance > MaxDistance) {
			FloatUp = !FloatUp;
			Distance = 0;
		}

		if (FloatUp) {
			transform.Translate(new Vector3(0, BounceSpeed * Time.deltaTime, 0));
		} else {
			transform.Translate(new Vector3(0, BounceSpeed * -Time.deltaTime, 0));
		}

	}
}
