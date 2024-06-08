using UnrealBuildTool;

public class LatenzProjektClientTarget : TargetRules
{
	public LatenzProjektClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("LatenzProjekt");
	}
}
