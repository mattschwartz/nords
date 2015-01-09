using UnityEngine;
using System.Collections;

public class StupidAIController : MonoBehaviour 
{
//	public float Speed = 7;
//	public Transform Target;

//	private bool Arrived = false;
//	private float Distance;
//	private Quaternion Direction;

	private NavMeshAgent NMA;

	void Start()
	{
//		NMA = GetComponent<NavMeshAgent>();
	}

	void Update() 
	{
//		NMA.SetDestination(Target.position);
//		Distance = Random.Range(2f, 5f);
//		Direction = Quaternion.Euler(0, Random.Range(0, 360), 0);
//		NMA.SetDestination(transform.position + Direction * Vector3.forward * Distance);

//		if (Arrived) {
//			Distance = Random.Range(2f, 5f);
//			Direction = Quaternion.Euler(0, Random.Range(0, 360), 0);
//			Arrived = false;
//		} else {
//			rigidbody.MovePosition(transform.position + Direction * Vector3.forward * Time.deltaTime * Speed);
//			Distance -= Time.deltaTime * Speed;
//		}
//
//		if (Distance <= 0) {
//			Arrived = true;
//		}
	}
}
