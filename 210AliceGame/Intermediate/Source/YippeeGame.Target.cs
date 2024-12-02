using UnrealBuildTool;

public class YippeeGameTarget : TargetRules
{
	public YippeeGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("YippeeGame");
	}
}
