// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Flood_Game_3D : ModuleRules
{
	public Flood_Game_3D(ReadOnlyTargetRules Target) : base(Target)
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
			"Flood_Game_3D",
			"Flood_Game_3D/Variant_Platforming",
			"Flood_Game_3D/Variant_Platforming/Animation",
			"Flood_Game_3D/Variant_Combat",
			"Flood_Game_3D/Variant_Combat/AI",
			"Flood_Game_3D/Variant_Combat/Animation",
			"Flood_Game_3D/Variant_Combat/Gameplay",
			"Flood_Game_3D/Variant_Combat/Interfaces",
			"Flood_Game_3D/Variant_Combat/UI",
			"Flood_Game_3D/Variant_SideScrolling",
			"Flood_Game_3D/Variant_SideScrolling/AI",
			"Flood_Game_3D/Variant_SideScrolling/Gameplay",
			"Flood_Game_3D/Variant_SideScrolling/Interfaces",
			"Flood_Game_3D/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
