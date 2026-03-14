// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SoulLike : ModuleRules
{
	public SoulLike(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SoulLike",
			"SoulLike/Variant_Platforming",
			"SoulLike/Variant_Platforming/Animation",
			"SoulLike/Variant_Combat",
			"SoulLike/Variant_Combat/AI",
			"SoulLike/Variant_Combat/Animation",
			"SoulLike/Variant_Combat/Gameplay",
			"SoulLike/Variant_Combat/Interfaces",
			"SoulLike/Variant_Combat/UI",
			"SoulLike/Variant_SideScrolling",
			"SoulLike/Variant_SideScrolling/AI",
			"SoulLike/Variant_SideScrolling/Gameplay",
			"SoulLike/Variant_SideScrolling/Interfaces",
			"SoulLike/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
