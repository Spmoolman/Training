using System;
using System.Collections.Generic;

namespace Reactive_Extensions
{
	class Program
	{
		/// <summary>
		/// https://rehansaeed.com/reactive-extensions-part1-replacing-events/
		/// This is based on the link above
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			try
			{
				//List of jetfighters to subscribe to
				List<JetFighter> fighters = new List<JetFighter>
				{
					new JetFighter
					{
						Name = "Eurofighter"
					},
					new JetFighter
					{
						Name = "UFO"
					},
					new JetFighter
					{
						Name = "Some other plane"
					},
				};

				BomberControl bc = new BomberControl(fighters);

				//Change this to an index of one of the list items
				// Index 1 should throw an error, see JetFighter class
				bc.ISawThis(fighters[0]);

				Console.ReadLine();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}
