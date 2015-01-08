using Nords.Units;
using System.Collections.Generic;

namespace Nords.Resources
{
    public class ResourcePoint 
    {
		#region Members

		private int _maxWorkers;
        private string _name;
		private List<Worker> _workers;

        public string Name
        {
            get
            {
                return _name;
            }
        }
		public List<Worker> Workers
		{
			get
			{
				return _workers;
			}
		}

        #endregion

		public ResourcePoint(string name, int maxWorkers)
		{
			_name = name;
			_maxWorkers = maxWorkers;
			_workers = new List<Worker>();
		}

		public int NumWorkers()
		{
			return _workers.Count;
		}

		public bool AssignWorker(Worker worker)
		{
			if (_workers.Count == _maxWorkers) { return false; }

			if (worker.Assign(this)) {
				_workers.Add(worker);
				return true;
			}

			return false;
		}

		public void ClearWorkers()
		{
			_workers.ForEach(t => t.Unassign());
			_workers.Clear();
		}
    }
}
