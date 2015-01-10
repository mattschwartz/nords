using UnityEngine;
using Nords.Units;

namespace Nords.Tasks
{
	public class Task
	{
		public delegate void TaskAssignment();

		public Unit AssignedUnit;
		public TaskAssignment Assignment;

		public Task(TaskAssignment assignment)
		{
			Assignment = assignment;
		}

		public bool HasWorker()
		{
			return AssignedUnit != null;
		}

		public void PickupTask(Unit unit)
		{
			if (AssignedUnit == null) { 
				AssignedUnit = unit;
			}
		}

		public void Perform()
		{
		}
	}
}
