using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nords.Tasks
{
	public class TaskDispatcher : MonoBehaviour
	{
		private List<Task> _tasks;
		public List<Task> AvailableTasks
		{
			get
			{
				return _tasks;
			}
		}

		public static TaskDispatcher Instance { get; private set; }

		void Start()
		{
			if (Instance == null) {
				Instance = this;
				DontDestroyOnLoad(this);
			} else if (this != Instance) {
				Destroy(this.gameObject);
			}

			Instance._tasks = new List<Task>();
		}

		void Update()
		{
			Instance._tasks.Where(t => t.HasWorker()).ToList()
				    .ForEach(t => t.Assignment());
		}

		public void Dispatch(Task task)
		{
			_tasks.Add(task);
		}
	}
}
