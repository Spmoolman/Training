using System;
using System.Reactive.Subjects;

namespace Reactive_Extensions
{
	public class JetFighter
	{
		private readonly Subject<JetFighter> planeSpotted = new Subject<JetFighter>();
		public string Name { get; set; }

		public IObservable<JetFighter> PlaneSpotted
		{
			get { return this.planeSpotted; }
		}

		public void AllPlanesSpotted()
		{
			this.planeSpotted.OnCompleted();
		}

		public void SpotPlane(JetFighter jetFighter)
		{
			try
			{
				if (string.Equals(jetFighter.Name, "UFO"))
				{
					throw new Exception("UFO Found");	
				}

				this.planeSpotted.OnNext(jetFighter);
			}
			catch (Exception exception)
			{
				this.planeSpotted.OnError(exception);
			}
		}
	}
}
