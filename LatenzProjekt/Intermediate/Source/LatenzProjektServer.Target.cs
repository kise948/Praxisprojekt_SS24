using UnrealBuildTool;

public class LatenzProjektServerTarget : TargetRules
{
	public LatenzProjektServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("LatenzProjekt");
	}
}
