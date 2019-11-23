// Copyright 2019 Marc O. R�del. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RearrangedChildCompTarget : TargetRules
{
	public RearrangedChildCompTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "RearrangedChildComp" } );
	}
}
