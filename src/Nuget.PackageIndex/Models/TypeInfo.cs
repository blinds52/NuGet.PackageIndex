﻿using System.Collections.Generic;
using System.Text;

namespace Nuget.PackageIndex.Models
{
    /// <summary>
    /// Type metadata exposed publicly 
    /// </summary>
    public class TypeInfo
    { 
        public string Name { get; set; }
        public string FullName { get; set; }
        public string AssemblyName { get; set; }
        public string PackageName { get; set; }
        public string PackageVersion { get; set; }
        public List<string> TargetFrameworks { get; internal set; }

        public TypeInfo()
        {
            TargetFrameworks = new List<string>();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(FullName)
                         .Append(",")
                         .Append(AssemblyName)
                         .Append(",")
                         .Append(PackageName)
                         .Append(" ")
                         .Append(PackageVersion)
                         .Append(", Target Frameworks: ")
                         .Append(GetTargetFrameworksString());

            return stringBuilder.ToString();
        }

        protected string GetTargetFrameworksString()
        {
            return string.Join(";", TargetFrameworks) ?? "";
        }
    }
}
