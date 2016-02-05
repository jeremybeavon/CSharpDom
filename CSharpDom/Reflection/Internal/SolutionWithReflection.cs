using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection.Internal
{
    public sealed class SolutionWithReflection : AbstractSolution<ProjectWithReflection>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly IReadOnlyCollection<ProjectWithReflection> projects;

        internal SolutionWithReflection(AssemblyWithReflection assembly)
        {
            this.assembly = assembly;
            projects = new ProjectWithReflection[] { new ProjectWithReflection(this, assembly) };
        }

        public override IReadOnlyCollection<ProjectWithReflection> Projects
        {
            get { return projects; }
        }
    }
}
