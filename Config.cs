using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace SubworldLibrary;

public class Config : ModConfig
{
	public override ConfigScope Mode => ConfigScope.ServerSide;

	[DefaultValue(true)]
	public bool PreloadSubservers;
}