using Sandbox.UI;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace StealthyTerry
{
	/// <summary>
	/// This is the HUD entity. It creates a RootPanel clientside, which can be accessed
	/// via RootPanel on this entity, or Local.Hud.
	/// </summary>
	public partial class StealthyTerryHudEntity : Sandbox.HudEntity<RootPanel>
	{
		public StealthyTerryHudEntity()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "/StealthyTerryhud.html" );
			}
		}
	}

}
