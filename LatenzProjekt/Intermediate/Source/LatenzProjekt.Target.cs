using UnrealBuildTool;

public class LatenzProjektTarget : TargetRules
{
	public LatenzProjektTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("LatenzProjekt");
	}
}
