using UnityEngine;
using Nords.Resources;
using Nords.Tasks;

namespace Nords.Units 
{
	// Basic unit that moves around on the map, either bc of the player
	// or some other event
	public class Unit : MonoBehaviour
	{
		private string _name;
		private Task _task;

		public string Name
		{
			get
			{
				return _name;
			}
		}

		public Unit(string name)
		{
			_name = name;
		}

		void Update()
		{
			if (_task != null) { return; }

			foreach (var task in TaskDispatcher.Instance.AvailableTasks) {
				if (IsAppropriate(task)) {
					task.PickupTask(this);
					_task = task;
					break;
				}
			}
		}

		public void PerformTask()
		{
			if (_task == null) { return; }

		}

		private bool IsAppropriate(Task task)
		{
			return true;
		}
	}
}
