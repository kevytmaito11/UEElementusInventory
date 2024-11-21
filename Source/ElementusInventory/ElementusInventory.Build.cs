// Author: Lucas Vilas-Boas
// Year: 2023
// Repo: https://github.com/lucoiso/UEElementusInventory

using UnrealBuildTool;

public class ElementusInventory : ModuleRules
{
	public ElementusInventory(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Cpp17;

		PublicDependencyModuleNames.AddRange(new[]
		{
			"Core",
            "GameplayAbilities" // Required for FGameplayAttribute and related functionality
		});

		PrivateDependencyModuleNames.AddRange(new[]
		{
			"Engine",
			"NetCore",
			"CoreUObject",
            "GameplayTags",      // Required for tag-based systems
            "DeveloperSettings"
		});
	}
}