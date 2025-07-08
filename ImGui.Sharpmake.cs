using Sharpmake; // contains the entire Sharpmake object library.
using System;

namespace Vital;

[Generate]
class ImGuiProject : BaseVitalProject
{
    public ImGuiProject()
    {
        Name = "ImGui";
        SourceRootPath = @"[project.SharpmakeCsPath]";

        AddTargets(Target.GetDefaultTargets(false));
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);
        conf.SolutionFolder = "Extern";

        conf.IncludePaths.Add(@"[project.SharpmakeCsPath]");
        conf.Options.Add(Options.Vc.General.WarningLevel.Level1);
        conf.Output = Configuration.OutputType.Lib;
    }
}
