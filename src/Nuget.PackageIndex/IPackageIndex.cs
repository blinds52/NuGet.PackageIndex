﻿using System.Collections.Generic;
using Nuget.PackageIndex.Models;

namespace Nuget.PackageIndex
{
    /// <summary>
    /// Represents package index and exposes common operations for all index types (local, remote)
    /// </summary>
    public interface IPackageIndex
    {
        IList<TypeInfo> GetTypes(string typeName);
        IList<PackageInfo> GetPackages(string packageName);
    }
}
