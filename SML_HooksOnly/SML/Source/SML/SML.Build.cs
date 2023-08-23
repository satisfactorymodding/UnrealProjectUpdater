// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Text;
using EpicGames.Core;

public class SML : ModuleRules
{
    public SML(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bLegacyPublicIncludePaths = false;
        
        PublicDependencyModuleNames.AddRange(new[]
        {
            "Core", "CoreUObject"
        });
        
        var thirdPartyFolder = Path.Combine(ModuleDirectory, "../../ThirdParty");
        PublicIncludePaths.Add(Path.Combine(thirdPartyFolder, "include"));
        
        var platformName = Target.Platform.ToString();
        var libraryFolder = Path.Combine(thirdPartyFolder, platformName);
        
        PublicAdditionalLibraries.Add(Path.Combine(libraryFolder, "funchook.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(libraryFolder, "AssemblyAnalyzer.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(libraryFolder, "Zydis.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(libraryFolder, "Zycore.lib"));
    }
}
