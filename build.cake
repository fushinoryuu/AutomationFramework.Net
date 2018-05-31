///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var solutionFile = "./src/AutomationFramework.Net.sln";

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
   // Executed BEFORE the first task.
   Information("Running tasks...");
});

Teardown(ctx =>
{
   // Executed AFTER the last task.
   Information("Finished running tasks.");
});

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Build");

Task("Clean")
    .Does(() =>
    {
        CleanDirectory("./")
    });

Task("RestoreNuget")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        foreach (var project in ParseSolution(solutionFile).Projects)
        {
            DotNetCoreRestore(project.Path.ToString());
        }
    });

Task("Build")
    .IsDependentOn("RestoreNuget")
    .Does(() =>
    {
        foreach (var project in ParseSolution(solutionFile).Projects)
        {
            DotNetCoreBuild(project.Path.ToString(), new DotNetCoreBuildSettings
            {
                Configuration = configuration
            });
        }
    });

RunTarget(target);