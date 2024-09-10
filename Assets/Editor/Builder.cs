using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Builder
{
    [MenuItem("Build/Build Win")]
    public static void Build()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/UHFPS/Content/Scenes/MainMenu.unity", 
            "Assets/UHFPS/Content/Scenes/LevelManager.unity", 
            "Assets/UHFPS/_Demo/Scenes/Playground.unity",
            "Assets/UHFPS/_Demo/Scenes/Elevator.unity",
            "Assets/UHFPS/_Demo/Scenes/Raining.unity",
        };
        buildPlayerOptions.locationPathName = "winBuild";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
        }
    }
}