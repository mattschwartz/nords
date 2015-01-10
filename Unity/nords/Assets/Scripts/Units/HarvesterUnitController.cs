using UnityEngine;
using System.Collections;

public class HarvesterUnitController : MonoBehaviour 
{
	private enum Instructions { harvest, deposit }

	public int MaxLoad;
	public Transform ResourceLocation;
	public Transform HomeBaseLocation;

	private bool Working;
	public float CurrentLoad;
	private float WorkSpeed = 7;
	private Vector3 WaitPosition;
	private Instructions CurrentInstruction;
	private NavMeshAgent Agent;

	void Start()
	{
		Agent = GetComponent<NavMeshAgent>();
		WaitPosition = transform.position;
	}

	void Update()
	{
		if (!Working) { return; }

		if (Agent.remainingDistance >= 1f) { return; }

		switch (CurrentInstruction) {
			case Instructions.harvest:
				CurrentLoad += WorkSpeed * Time.deltaTime;

				if (CurrentLoad >= MaxLoad) {
					CurrentInstruction = Instructions.deposit;
					Agent.SetDestination(HomeBaseLocation.position);
				}
				break;
			case Instructions.deposit:
				CurrentLoad -= WorkSpeed * Time.deltaTime;

				if (CurrentLoad <= 0) {
					CurrentInstruction = Instructions.harvest;
					Agent.SetDestination(ResourceLocation.position);
				}
				break;
		}
	}

	public void BeginWork()
	{
		Working = true;

		if (CurrentLoad > 0) {
			CurrentInstruction = Instructions.deposit;
			Agent.SetDestination(HomeBaseLocation.position);
		} else {
			CurrentInstruction = Instructions.harvest;
			Agent.SetDestination(ResourceLocation.position);
		}
	}

	public void StopWork()
	{
		Working = false;
		Agent.SetDestination(WaitPosition);
	}
}
