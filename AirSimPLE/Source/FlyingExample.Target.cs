// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FlyingExampleTarget : TargetRules
{
	public FlyingExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.AddRange(new string[] { "AirSimPLE" });
		DefaultBuildSettings = BuildSettingsVersion.V2;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;

		if (Target.Platform == UnrealTargetPlatform.Linux)
			bUsePCHFiles = false;
	}
}
