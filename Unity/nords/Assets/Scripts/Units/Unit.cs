using Nords.Resources;

namespace Nords.Units 
{
	// Basic unit that moves around on the map, either bc of the player
	// or some other event
	public class Unit 
	{
		private string _name;
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
	}
}
