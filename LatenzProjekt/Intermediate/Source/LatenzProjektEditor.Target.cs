using UnrealBuildTool;

public class LatenzProjektEditorTarget : TargetRules
{
	public LatenzProjektEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("LatenzProjekt");
	}
}
