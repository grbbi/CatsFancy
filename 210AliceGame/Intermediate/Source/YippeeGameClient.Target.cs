using UnrealBuildTool;

public class YippeeGameClientTarget : TargetRules
{
	public YippeeGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("YippeeGame");
	}
}
