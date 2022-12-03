using UnrealBuildTool;

public class HW2_HunterHodenTarget : TargetRules
{
	public HW2_HunterHodenTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HW2_HunterHoden");
	}
}
