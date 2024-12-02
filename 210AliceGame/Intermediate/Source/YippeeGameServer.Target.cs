using UnrealBuildTool;

public class YippeeGameServerTarget : TargetRules
{
	public YippeeGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("YippeeGame");
	}
}
