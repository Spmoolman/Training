using System;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace Reactive_Extensions
{
	public class BomberControl : IDisposable
	{
		private IDisposable planeSpottedSubscription;

		public BomberControl(List<JetFighter> fighters)
		{
			//This will subscribe to the OnPlaneSpotted method
			fighters.ForEach(fighter => fighter.PlaneSpotted.Subscribe(this.OnPlaneSpotted));			
		}

		public void ISawThis(JetFighter jetFighter)
		{
			jetFighter.SpotPlane(jetFighter);
		}

		public void Dispose()
		{
			this.planeSpottedSubscription.Dispose();
		}

		private void OnPlaneSpotted(JetFighter jetFighter)
		{
			JetFighter spottedPlane = jetFighter;
			Console.WriteLine(spottedPlane.Name);
		}
	}
}
