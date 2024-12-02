using UnrealBuildTool;

public class YippeeGameEditorTarget : TargetRules
{
	public YippeeGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("YippeeGame");
	}
}
