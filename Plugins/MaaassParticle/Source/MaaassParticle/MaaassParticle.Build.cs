// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class MaaassParticle : ModuleRules
{
	public MaaassParticle(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "EnhancedInput",
			
            // General
            "GameplayTags",
            "ZoneGraph",

			// Niagara VFX
			"Niagara",
			
			// Mass Framework
			"StructUtils",
            "MassEntity",
            "MassCommon",
            "MassMovement",
            "MassNavigation",
            "MassSimulation",
            "MassSpawner",
            "MassLOD",
            "MassAIBehavior",
            "StateTreeModule",

			// AnimToTexture (Runtime Part)
			"AnimToTexture",

			// Other Runtime Dependencies
			"RenderCore",
            "RHI",
            "VectorVM",
            "ApplicationCore"
            
            
        });

        PrivateDependencyModuleNames.AddRange(new string[]
        {

		});

        PublicIncludePaths.AddRange(new string[]
        {
            Path.Combine(ModuleDirectory, "Public/MassEntity/Fragments"),
            Path.Combine(ModuleDirectory, "Public/MassEntity/Fragments/TriggerVolume"),
            Path.Combine(ModuleDirectory, "Public/MassEntity/Processors"),
            Path.Combine(ModuleDirectory, "Public/MassEntity/Processors/TriggerVolume"),
            Path.Combine(ModuleDirectory, "Public/MassEntity/Tasks"),
            Path.Combine(ModuleDirectory, "Public/MassEntity/Traits"),
            Path.Combine(ModuleDirectory, "Public/NiagaraDataInterface"),
            Path.Combine(ModuleDirectory, "Public/Utils"),
            Path.Combine(ModuleDirectory, "Public/TriggerVolume/Components"),
            Path.Combine(ModuleDirectory, "Public/TriggerVolume/DataAssets"),
            Path.Combine(ModuleDirectory, "Public/TriggerVolume/Subsystems"),
            Path.Combine(ModuleDirectory, "Public/TriggerVolume/Tasks"),
        });

        PrivateIncludePaths.AddRange(new string[]
        {
            Path.Combine(ModuleDirectory, "Private/MassEntity/Fragments"),
            Path.Combine(ModuleDirectory, "Private/MassEntity/Processors"),
            Path.Combine(ModuleDirectory, "Private/MassEntity/Processors/TriggerVolume"),
            Path.Combine(ModuleDirectory, "Private/MassEntity/Tasks"),
            Path.Combine(ModuleDirectory, "Private/MassEntity/Traits"),
            Path.Combine(ModuleDirectory, "Private/NiagaraDataInterface"),
            Path.Combine(ModuleDirectory, "Private/TriggerVolume/Components"),
            Path.Combine(ModuleDirectory, "Private/TriggerVolume/DataAssets"),
            Path.Combine(ModuleDirectory, "Private/TriggerVolume/Subsystems"),
            Path.Combine(ModuleDirectory, "Private/TriggerVolume/Tasks"),
        });
    }
}
