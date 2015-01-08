using Nords.Resources;

namespace Nords.Units
{
	public class Worker : Unit 
	{
		private ResourcePoint _resource;

		public Worker(string name) 
			: base(name) 
		{ }
		
		public bool Assign(ResourcePoint resource)
		{
			if (_resource != null) { return false; }
			
			_resource = resource;
			
			return true;
		}
		
		public void Unassign()
		{
			_resource = null;
		}
	}
}
