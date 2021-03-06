﻿using System.Collections.Generic;
using Nuget.PackageIndex.Client;

namespace Nuget.PackageIndex.VisualStudio.Analyzers
{
    public delegate void ProjectTargetFrameworkChanged(object sender, EnvDTE.Project project);

    /// <summary>
    /// Projects should Export this interface to provide target frameworks supported 
    /// by given DTE project. This is needed since different rpojec system types might have
    /// different strategy for target frameworks. For example csproj has one target framework, 
    /// xproj can have multiple.
    /// </summary>
    public interface IProjectTargetFrameworkProvider
    {
        bool SupportsProject(EnvDTE.Project project);
        IEnumerable<TargetFrameworkMetadata> GetTargetFrameworks(EnvDTE.Project project);
        event ProjectTargetFrameworkChanged TargetFrameworkChanged;
        void RefreshTargetFrameworks(EnvDTE.Project project);
    }
}
