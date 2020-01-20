using UnrealBuildTool;

public class CustomAssetEditor : ModuleRules
{
    public CustomAssetEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        
        PublicDependencyModuleNames.AddRange(
            new string[] 
            { 
                "Core", 
                "CoreUObject", 
                "Engine", 
                "InputCore"

                // ... add public dependencies that you statically link with here ...   
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[] 
            {
                "Tutorial"

                // ... add private dependencies that you statically link with here ...    
            }
        );

        PublicIncludePaths.AddRange(
            new string[]
            {
                "CustomAssetEditor/Public"
            }
        );

        PrivateIncludePaths.AddRange(
            new string[]
            {
                "CustomAssetEditor/Private"
            }
        );
    }
}